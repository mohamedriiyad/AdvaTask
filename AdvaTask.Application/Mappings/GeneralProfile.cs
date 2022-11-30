using AdvaTask.Application.DTOs.Departments;
using AdvaTask.Application.DTOs.Employees;
using AdvaTask.Domain.Models;
using AutoMapper;

namespace AdvaTask.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            //Employees
            CreateMap<AddEmployeeDTO, Employee>();
            CreateMap<EditEmployeeDTO, Employee>();

            //Departments
            CreateMap<AddDepartmentDTO, Department>();
            CreateMap<EditDepartmentDTO, Department>();
        }
    }
}
