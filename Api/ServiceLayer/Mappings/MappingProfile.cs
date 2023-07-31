using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTO_s.Account;
using ServiceLayer.DTO_s.Author;
using ServiceLayer.DTO_s.Banner;
using ServiceLayer.DTO_s.Contact;
using ServiceLayer.DTO_s.Course;
using ServiceLayer.DTO_s.Service;
using ServiceLayer.DTO_s.Student;
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
            CreateMap<Slider, SliderDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Slider, SliderListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Slider, SliderCreateDto>().ReverseMap();
            CreateMap<Slider, SliderUpdateDto>().ReverseMap();


            CreateMap<Banner, BannerDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Banner, BannerListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Banner, BannerCreateDto>().ReverseMap();
            CreateMap<Banner, BannerUpdateDto>().ReverseMap();


            CreateMap<Title, TitleDto>().ReverseMap();
            CreateMap<Title, TitleListDto>().ReverseMap();
            CreateMap<Title, TitleCreateDto>().ReverseMap();
            CreateMap<Title, TitleUpdateDto>().ReverseMap();


            CreateMap<Header, HeaderDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Header, HeaderListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Header, HeaderCreateDto>().ReverseMap();
            CreateMap<Header, HeaderUpdateDto>().ReverseMap();


            CreateMap<About, AboutDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<About, AboutListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<About, AboutCreateDto>().ReverseMap();
            CreateMap<About, AboutUpdateDto>().ReverseMap();


            CreateMap<Service, ServiceDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Service, ServiceListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Service, ServiceCreateDto>().ReverseMap();
            CreateMap<Service, ServiceUpdateDto>().ReverseMap();


            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, ContactListDto>().ReverseMap();
            CreateMap<Contact, ContactCreateDto>().ReverseMap();
            CreateMap<Contact, ContactUpdateDto>().ReverseMap();


            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(c => c.CourseAuthors.Where(ca => ca.CourseId == c.Id).Select(ca => ca.Author.Name)))
                .ForMember(dest => dest.StudentFullName, opt => opt.MapFrom(c => c.Students.Select(s => s.FullName)))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Course, CourseListDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(c => c.CourseAuthors.Where(ca => ca.CourseId == c.Id).Select(ca => ca.Author.Name)))
                .ForMember(dest => dest.StudentFullName, opt => opt.MapFrom(c => c.Students.Select(s => s.FullName)))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(c => Convert.ToBase64String(c.Image)))
                .ReverseMap();
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();


            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(a => a.CourseAuthors.Where(ca => ca.AuthorId == a.Id).Select(ca => ca.Course.Title)))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Author, AuthorListDto>()
                .ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(a => a.CourseAuthors.Where(ca => ca.AuthorId == a.Id).Select(ca => ca.Course.Title)))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Author, AuthorCreateDto>().ReverseMap();
            CreateMap<Author, AuthorUpdateDto>().ReverseMap();


            CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(s => s.Course.Title))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Student, StudentListDto>()
                .ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(s => s.Course.Title))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Student, StudentCreateDto>().ReverseMap();
            CreateMap<Student, StudentUpdateDto>().ReverseMap();


            CreateMap<RegisterDto, AppUser>().ReverseMap();
            CreateMap<UserDto, AppUser>().ReverseMap();
        }
    }
}

