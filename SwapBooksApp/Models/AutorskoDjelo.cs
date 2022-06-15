
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapBooksApp.Models
{
    public class AutorskoDjelo
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Ocjena { get; set; }

          [ForeignKey("Korisnik")]
        public string korisnikId { get; set; }
        public Korisnik Korisnik { get; set; }  

        public double Cijena { get; set; }
        public string Autor { get; set; }
        public AutorskoDjelo() { }
    }
}
