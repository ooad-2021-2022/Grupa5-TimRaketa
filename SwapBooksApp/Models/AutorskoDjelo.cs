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
        public int AutorId { get; set; }

        public Korisnik autor { get; set; }
           
        public AutorskoDjelo() { }
    }
}
