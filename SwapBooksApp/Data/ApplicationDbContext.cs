using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwapBooksApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapBooksApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AutorskoDjelo> AutorskoDjelo { get; set; }
        public DbSet<Knjiga> Knjiga { get; set; }
    
        public DbSet<Notifikacija> Notifikacija { get; set; }
        public DbSet<Racun> Racun { get; set; }
        public DbSet<Razmjena> Razmjena { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutorskoDjelo>().ToTable("AutorskoDjelo");
            modelBuilder.Entity<Knjiga>().ToTable("Knjiga");
            modelBuilder.Entity<Notifikacija>().ToTable("Notifikacija");
            modelBuilder.Entity<Racun>().ToTable("Racun");
            modelBuilder.Entity<Razmjena>().ToTable("Razmjena");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            base.OnModelCreating(modelBuilder);
        }

    }
}
