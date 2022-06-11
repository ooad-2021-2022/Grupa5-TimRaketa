using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapBooksApp.Models
{
    public class Notifikacija
    {
        [Key]
        public int Id { get; set; }
        public string Poruka { get; set; }
        public DateTime Datum { get; set; }
        [ForeignKey("Korisnik")]
        public int KorisnikId { get; set; }

        public int Korisnik { get; set; }

        public VrstaNotifikacije Svrha { get; set; }

        public Notifikacija()
        {

        }

    }
}
