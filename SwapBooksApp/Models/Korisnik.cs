using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapBooksApp.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        [ForeignKey("Racun")]
        public int RacunId { get; set; }
        public Racun Racun { get; set; }
        public VrstaKorisnika Vrsta { get; set; }
        public Korisnik()
        {

        }

    }
}
