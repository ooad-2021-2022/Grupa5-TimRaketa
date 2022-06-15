using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapBooksApp.Models
{
    public class Racun
    {
        [Key]
        public int Id { get; set; }
  [ForeignKey("Korisnik")]
        public string korisnikId { get; set; }
        public Korisnik Korisnik { get; set; }  

        public double Stanje { get; set; }

        public Racun()
        {

        }
    }
}

