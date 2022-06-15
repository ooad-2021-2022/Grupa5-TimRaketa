using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapBooksApp.Models
{
    public class Razmjena
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Knjiga")]
        public int Knjiga1Id { get; set; }
        [ForeignKey("Knjiga")]
        public int Knjiga2Id { get; set; }
        public DateTime Datum { get; set; }
        [ForeignKey("Korisnik")]
        public string korisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        public Knjiga Knjiga1 { get; set; }
        public Knjiga Knjiga2 { get; set; }
        public Razmjena() { }

    }
}
