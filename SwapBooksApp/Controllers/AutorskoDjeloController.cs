using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SwapBooksApp.Data;
using SwapBooksApp.Models;

namespace SwapBooksApp.Controllers
{
    [Authorize(Roles = "Administrator, SuperKorisnik")]
    public class AutorskoDjeloController : Controller
    {
        private readonly ApplicationDbContext _context;
        private  UserManager<Korisnik> userManager;

        public AutorskoDjeloController(ApplicationDbContext context, UserManager<Korisnik> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        // GET: AutorskoDjelo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AutorskoDjelo.Include(a => a.Korisnik);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AutorskoDjelo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autorskoDjelo = await _context.AutorskoDjelo
                .Include(a => a.Korisnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autorskoDjelo == null)
            {
                return NotFound();
            }

            return View(autorskoDjelo);
        }

        // GET: AutorskoDjelo/Create
        public IActionResult Create()
        {
            ViewData["korisnikId"] = new SelectList(_context.Set<Korisnik>(), "Id", "Id");
            return View();
        }

        // POST: AutorskoDjelo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Ocjena,korisnikId,Cijena,Autor")] AutorskoDjelo autorskoDjelo)
        {
            if (ModelState.IsValid)
            {

                Korisnik korisnik = (await userManager.GetUserAsync(HttpContext.User));
                autorskoDjelo.korisnikId = korisnik.Id;
                // knjiga.Korisnik = korisnik;
                

                _context.Add(autorskoDjelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["korisnikId"] = new SelectList(_context.Set<Korisnik>(), "Id", "Id", autorskoDjelo.korisnikId);
            return View(autorskoDjelo);
        }

        // GET: AutorskoDjelo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autorskoDjelo = await _context.AutorskoDjelo.FindAsync(id);
            if (autorskoDjelo == null)
            {
                return NotFound();
            }
            ViewData["korisnikId"] = new SelectList(_context.Set<Korisnik>(), "Id", "Id", autorskoDjelo.korisnikId);
            return View(autorskoDjelo);
        }

        // POST: AutorskoDjelo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Ocjena,korisnikId,Cijena,Autor")] AutorskoDjelo autorskoDjelo)
        {
            if (id != autorskoDjelo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autorskoDjelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutorskoDjeloExists(autorskoDjelo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["korisnikId"] = new SelectList(_context.Set<Korisnik>(), "Id", "Id", autorskoDjelo.korisnikId);
            return View(autorskoDjelo);
        }

        // GET: AutorskoDjelo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autorskoDjelo = await _context.AutorskoDjelo
                .Include(a => a.Korisnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autorskoDjelo == null)
            {
                return NotFound();
            }

            return View(autorskoDjelo);
        }

        // POST: AutorskoDjelo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autorskoDjelo = await _context.AutorskoDjelo.FindAsync(id);
            _context.AutorskoDjelo.Remove(autorskoDjelo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutorskoDjeloExists(int id)
        {
            return _context.AutorskoDjelo.Any(e => e.Id == id);
        }
        public async Task<IActionResult> Biblioteka()

        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var knjige = _context.AutorskoDjelo.
                        Where(k => k.korisnikId.Equals(userId));
            return View(await knjige.ToListAsync());

        }
    }
}
