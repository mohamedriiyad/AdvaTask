using AdvaTask.Application.DTOs;
using AdvaTask.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

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
