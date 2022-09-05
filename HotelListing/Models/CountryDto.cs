using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelListing.Data;

namespace HotelListing.Models
{
    public class CreateCountryDto
    {

        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "Country Name is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "Short Name is Too Long")]
        public string ShortName { get; set; }

    }

    public class CountryDto : CreateCountryDto
    {
        public int Id { get; set; }
        public virtual IList<HotelDto> Hotels { get; set; }
    }
}
