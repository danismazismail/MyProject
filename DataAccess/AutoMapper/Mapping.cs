using AutoMapper;
using Core.Dtos.PersonDto;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Person,CreatePersonDto>().ReverseMap();
            CreateMap<Person,GetPersonDto>().ReverseMap();
            CreateMap<Person,UpdatePersonDto>().ReverseMap();
        }
    }
}
