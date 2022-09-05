namespace HotelListing.Models
{
    public class HotelDto : CreateHotelDto
    {
        public int Id { get; set; }

        public CountryDto CountryDto { get; set; }  
    }
}