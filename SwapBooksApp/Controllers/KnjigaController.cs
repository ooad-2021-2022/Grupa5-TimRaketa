using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SwapBooksApp.Service;

namespace SwapBooksApp.Controllers
{
    public class KnjigaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserService userService;
        private  UserManager<Korisnik> userManager;

        public KnjigaController(ApplicationDbContext context, IUserService userService, UserManager<Korisnik> userManager)
        {
            _context = context;
            this.userService = userService;
            this.userManager = userManager;
        }

        // GET: Knjiga
        public async Task<IActionResult> Index(string id)

        {

            if (!String.IsNullOrEmpty(id))
            {
                var knjige = _context.Knjiga.
                          Where(s => s.Naziv!.Contains(id));
                return View(await knjige.ToListAsync());
            }
            else
            {
                var applicationDbContext = _context.Knjiga.Include(k => k.Korisnik);
                return View(await applicationDbContext.ToListAsync());
            }
        }
        // GET: Knjiga/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knjiga = await _context.Knjiga
                .Include(k => k.Korisnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knjiga == null)
            {
                return NotFound();
            }

            return View(knjiga);
        }

        // GET: Knjiga/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["korisnikId"] = new SelectList(_context.Set<Korisnik>(), "Id", "Id");
            return View();
        }

        // POST: Knjiga/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,Naziv,korisnikId,Zauzeta,Slika")] Knjiga knjiga)
        {
            if (ModelState.IsValid)
            {
                Korisnik korisnik = (await userManager.GetUserAsync(HttpContext.User));
                knjiga.korisnikId = korisnik.Id;
               // knjiga.Korisnik = korisnik;
               _context.Add(knjiga);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            Debug.WriteLine("Selma");


            /*var userId = userService.getUserId();

            knjiga.Korisnik = userService.getUser();
            knjiga.korisnikId = Korisnik.Id;
            */
            //  System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            /*   var id= userManager.GetUserId(User); 
               knjiga.korisnikId = id;
               knjiga.Korisnik=(Korisnik)_context.Users.
                           Where(k => k.Id.Equals(id));
            */



            ViewData["korisnikId"] = new SelectList(_context.Set<Korisnik>(), "Id", "Id");
            return View(knjiga);
        }
   
        // GET: Knjiga/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knjiga = await _context.Knjiga.FindAsync(id);
            if (knjiga == null)
            {
                return NotFound();
            }
            ViewData["korisnikId"] = new SelectList(_context.Set<Korisnik>(), "Id", "Id", knjiga.korisnikId);
            return View(knjiga);
        }

        // POST: Knjiga/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,korisnikId,Zauzeta,Slika")] Knjiga knjiga)
        {
            if (id != knjiga.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knjiga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnjigaExists(knjiga.Id))
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
            ViewData["korisnikId"] = new SelectList(_context.Set<Korisnik>(), "Id", "Id", knjiga.korisnikId);
            return View(knjiga);
        }

        // GET: Knjiga/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knjiga = await _context.Knjiga
                .Include(k => k.Korisnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knjiga == null)
            {
                return NotFound();
            }

            return View(knjiga);
        }

        // POST: Knjiga/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var knjiga = await _context.Knjiga.FindAsync(id);
            _context.Knjiga.Remove(knjiga);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnjigaExists(int id)
        {
            return _context.Knjiga.Any(e => e.Id == id);
        }
        //GET: Knjiga/Biblioteka
        public async Task<IActionResult> Biblioteka()

        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var knjige = _context.Knjiga.
                        Where(k => k.korisnikId.Equals(userId));
            return View(await knjige.ToListAsync());

        }
    }
}
