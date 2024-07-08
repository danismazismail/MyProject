using AutoMapper;
using Core.Dtos.PersonDto;
using DataAccess.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.UI.Controllers.Person
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _person;
        private readonly IMapper _mapper;

        public PersonController(IPersonRepository person, IMapper mapper)
        {
            _person = person;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Person()
        {
            var persons = await _person.GetFiltredListAsync(
                select: x => new GetPersonDto()
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = x.Address,
                    Age = x.Age,
                    CreatedDate = x.CreatedDate,
                    DateOfBirth = x.DateOfBirth,
                    Email = x.Email,
                    Gender = x.Gender,
                    PhoneNumber = x.PhoneNumber,
                    Status = x.Status,
                    UpdatedDate = x.UpdatedDate,
                },
                where: x => x.Status != Core.Entities.Abstract.Status.Passive,
                orderBy: x => x.OrderBy(x => x.CreatedDate)

            );

            return View(persons);
        }
    }

    
}
