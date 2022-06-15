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
        public string KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }  

        public bool Zauzeta{ get; set; }

       public string Slika { get; set; }
        public Knjiga() { }

    }
}
