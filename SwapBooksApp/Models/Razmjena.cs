using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapBooksApp.Models
{
    public class Razmjena
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Korisnik")]
        public int Korisnik1Id { get; set; }
        [ForeignKey("Korisnik")]
        public int Korisnik2Id { get; set; }
        [ForeignKey("Knjiga")]
        public int KnjigaId { get; set; }
        public DateTime Datum { get; set; }
        public Korisnik Korisnik1 { get; set; }
        public Korisnik Korisnik2 { get; set; }
        public Knjiga knjiga { get; set; }
        public Razmjena() { }

    }
}
