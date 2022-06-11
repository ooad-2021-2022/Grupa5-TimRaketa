using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapBooksApp.Models
{
    public class Knjiga
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        [ForeignKey("Korisnik")]
        public int KorisnikId { get; set; }
        public Korisnik korisnik { get; set; }

        public Knjiga() { }

    }
}
