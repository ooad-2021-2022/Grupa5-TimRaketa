using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapBooksApp.Models
{
    public class Recenzija
    {
        [Key]
        public int Id { get; set; }
        public double Ocjena { get; set; }
        public DateTime Datum { get; set; }
        [ForeignKey("AutorskoDjelo")]
        public int AutorskoDjeloId { get; set; }
        [ForeignKey("Korisnik")]
        public string korisnikId { get; set; }
        public Korisnik Korisnik { get; set; }


        public AutorskoDjelo AutorskoDjelo { get; set; }
       

        public Recenzija()
        {

        }
    }
}
