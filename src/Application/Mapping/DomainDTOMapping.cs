using AutoMapper;
using dotnet.src.Domain.DTOs;
using dotnet.src.Domain.Model.EmployeeAggregate;

namespace dotnet.src.Application.Mapping

{
    public class DomainDTOMapping : Profile
    {
        public DomainDTOMapping()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));
        }
    }
}