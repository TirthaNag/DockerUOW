using AutoMapper;
using DockerUOW.Entities;

namespace DockerUOW.Dto.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentEntity, StudentDto>();
        }
    }
}
