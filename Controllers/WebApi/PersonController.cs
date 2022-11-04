using AutoMapper;
using GSC_BackEnd_TP.DataAccess;
using GSC_BackEnd_TP.Dto;
using GSC_BackEnd_TP.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GSC_BackEnd_TP.Controllers.WebApi
{
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public PersonController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        [HttpPost]
        public IActionResult Create([FromBody] PersonDto personDto) 
        {
            //Validaciones de request
            if (personDto is null
               || string.IsNullOrWhiteSpace(personDto.Name) 
               || string.IsNullOrWhiteSpace(personDto.PhoneNumber)
               || string.IsNullOrWhiteSpace(personDto.Email))
                return BadRequest("Description is mandatory");
            Person person = mapper.Map<Person>(personDto);
            person=uow.PersonRepository.Add(person);
            uow.Complete();
            


            return Created($"/person /{person.Id}",person);
            //Ver en POSTMAN que el response tiene un header "Location"
        }




    }
}
