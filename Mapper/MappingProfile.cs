using AutoMapper;
using GSC_BackEnd_TP.Dto;
using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<PersonDto, Person>();
        }
    }
}
