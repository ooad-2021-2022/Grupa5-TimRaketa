using System.ComponentModel.DataAnnotations;

namespace SwapBooksApp.Models
{
    public enum VrstaNotifikacije
    {
        [Display(Name = "Razmjena")] RAZMJENA,
        [Display(Name = "Kupovina")] KUPOVINA,
        [Display(Name = "Prodaja")] PRODAJA,
        [Display(Name = "Recenzija")]RECENZIJA
    }
}
