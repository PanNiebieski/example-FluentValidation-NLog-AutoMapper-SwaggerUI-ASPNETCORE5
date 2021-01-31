using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddingStuffAndChecking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;

        public EmployeeController(IMapper
            mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public Employee Index()
        {
            EmployeeDto eDTO = new EmployeeDto()
            {
                Age = 61,
                Adress = new AdressDto()
                {
                    CityCode = "11250-50",
                    Country = "Poland",
                    Street = "Polonozea ",
                    StreetNumber = 128
                },
                EmployeeId = 121,
                FirstName = "Damian",
                LastName = "Morfeus",
                Login = "frankodomanamiga",
                OrganizationCompanyName = "LichyDzwig",
                OrganizationId = 34,
                Role = "Sprzątacz podłogi piętra 34",
                RootOrganizationCompanyName = "Dobra Winda",
                RootOrganizationId = 12,
                Type = "Sprzątacz",
                City = "White UnderWoods",
                Phone = "646555777"
            };

            return _mapper.Map<Employee>(eDTO);
        }
    }
}
