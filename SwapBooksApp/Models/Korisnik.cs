using Microsoft.AspNetCore.Identity;

namespace SwapBooksApp.Models
{
    public class Korisnik : IdentityUser
    {


        public string Ime { get; set; }
        public  string Prezime { get; set; }

        public Korisnik() 
        {
        }
    }
}
