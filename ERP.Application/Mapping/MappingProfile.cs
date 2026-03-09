using AutoMapper;
using ERP.Application.DTOs.Student;
using ERP.Domain.Entities;

namespace ERP.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentResponseDTO>();
            CreateMap<StudentCreateDTO, Student>();
            CreateMap<StudentUpdateDTO, Student>();
        }
    }
}
