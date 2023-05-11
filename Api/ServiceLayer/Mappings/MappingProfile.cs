using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Header;
using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.DTOs.Title;

namespace ServiceLayer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Slider, SliderListDto>().ReverseMap();
            CreateMap<Slider, SliderCreateDto>().ReverseMap();
            CreateMap<Slider, SliderUpdateDto>().ReverseMap();
            CreateMap<Slider, SliderDto>().ReverseMap();


            CreateMap<Title, TitleDto>().ReverseMap();


            CreateMap<Header, HeaderDto>().ReverseMap();
            CreateMap<Header, HeaderCreateDto>().ReverseMap();
        }
    }
}
