using System.ComponentModel.DataAnnotations;

namespace SwapBooksApp.Models
{
    public class Racun
    {
        [Key]
        public int Id { get; set; }
        public double Stanje { get; set; }
        public Racun()
        {

        }
    }
}
