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
        public string korisnikId { get; set; }
        public Korisnik Korisnik { get; set; }


        [EnumDataType(typeof(VrstaNotifikacije))]
        public VrstaNotifikacije Svrha { get; set; }

        public Notifikacija()
        {

        }

    }
}
