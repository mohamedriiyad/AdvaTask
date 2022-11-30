using AdvaTask.Application.DTOs.Employees;
using AdvaTask.Domain.Models;
using AutoMapper;

namespace AdvaTask.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<AddEmployeeDTO, Employee>();
            CreateMap<EditEmployeeDTO, Employee>();
        }
    }
}
