using AutoMapper;
using HotelListing.Data;
using HotelListing.Models;

namespace HotelListing.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
        }
    }
}
