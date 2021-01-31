using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddingStuffAndChecking
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeDto, Employee>()

               .ForMember(dest => dest.CurrentCity,
                    opt => opt.MapFrom(src => src.City))
               .ForMember(dest => dest.HomePhone,
                    opt => opt.MapFrom(src => src.Phone))
               .ForMember(dest => dest.isOver30, opt =>
                    opt.MapFrom(src => src.Age > 30 ? true : false))
               .ForMember(dest => dest.Comment, opt =>
                    opt.MapFrom(src => src.Age > 55 ? "Zaraz emerytura" : ""));

            CreateMap<AdressDto, Adress>()
                .ForMember(dest => dest.OnStreet,
                opt => opt.MapFrom
                (src => src.Street + " " + src.StreetNumber));
        }
    }

    public class AdressDto
    {
        public string CityCode { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Country { get; set; }
    }

    public class Adress
    {
        public string CityCode { get; set; }
        public string OnStreet { get; set; }
        public string Country { get; set; }
    }

    public class Employee
    {
        public string Comment { get; set; }
        public bool isOver30 { get; set; }

        public Adress Adress { get; set; }
        public string CurrentCity { get; set; }
        public string HomePhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string OrganizationCompanyName { get; set; }
        public int OrganizationId { get; set; }
        public string Role { get; set; }
        public string RootOrganizationCompanyName { get; set; }
        public int RootOrganizationId { get; set; }
        public string Type { get; set; }
        public int EmployeeId { get; set; }
    }

    public class EmployeeDto
    {
        public int Age { get; set; }

        public AdressDto Adress { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string OrganizationCompanyName { get; set; }
        public int OrganizationId { get; set; }
        public string Role { get; set; }
        public string RootOrganizationCompanyName { get; set; }
        public int RootOrganizationId { get; set; }
        public string Type { get; set; }
        public int EmployeeId { get; set; }
    }
}
