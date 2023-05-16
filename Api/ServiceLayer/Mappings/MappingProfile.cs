using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTO_s.Banner;
using ServiceLayer.DTO_s.Service;
using ServiceLayer.DTOs.about;
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
            CreateMap<Slider, SliderDto>().ReverseMap();
            CreateMap<Slider, SliderListDto>().ReverseMap();
            CreateMap<Slider, SliderCreateDto>().ReverseMap();
            CreateMap<Slider, SliderUpdateDto>().ReverseMap();

            CreateMap<Banner, BannerDto>().ReverseMap();
            CreateMap<Banner, BannerListDto>().ReverseMap();
            CreateMap<Banner, BannerCreateDto>().ReverseMap();
            CreateMap<Banner, BannerUpdateDto>().ReverseMap();

            CreateMap<Title, TitleDto>().ReverseMap();
            CreateMap<Title, TitleListDto>().ReverseMap();
            CreateMap<Title, TitleCreateDto>().ReverseMap();
            CreateMap<Title, TitleUpdateDto>().ReverseMap();

            CreateMap<Header, HeaderDto>().ReverseMap();
            CreateMap<Header, HeaderListDto>().ReverseMap();
            CreateMap<Header, HeaderCreateDto>().ReverseMap();
            CreateMap<Header, HeaderUpdateDto>().ReverseMap();

            CreateMap<About, AboutDto>().ReverseMap();
            CreateMap<About, AboutListDto>().ReverseMap();
            CreateMap<About, AboutCreateDto>().ReverseMap();
            CreateMap<About, AboutUpdateDto>().ReverseMap();

            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<Service, ServiceListDto>().ReverseMap();
            CreateMap<Service, ServiceCreateDto>().ReverseMap();
            CreateMap<Service, ServiceUpdateDto>().ReverseMap();
        }
    }
}
