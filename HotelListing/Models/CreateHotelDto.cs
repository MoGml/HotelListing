using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateHotelDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }

    }
}