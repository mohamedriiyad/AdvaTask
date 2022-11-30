using AdvaTask.Application.DTOs.Departments;
using AdvaTask.Application.Interfaces;
using AdvaTask.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdvaTask.WebUI.Controllers
{
    public class DepartmentsController : BaseController
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public DepartmentsController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }

        [HttpGet("get/{id}")]
        public Department Get(int id) => _departmentService.GetDepartment(id);

        [HttpGet("get")]
        public IEnumerable<Department> Get() =>_departmentService.GetDepartments();

        [HttpPost("create")]
        public IActionResult Create(AddDepartmentDTO departmentDTO) 
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var department = _mapper.Map<Department>(departmentDTO);
            _departmentService.AddDepartment(department);

            return Ok();
        }

        [HttpPut("edit")]
        public IActionResult Edit(EditDepartmentDTO departmentDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var department = _mapper.Map<Department>(departmentDTO);
            _departmentService.UpdateDepartment(department);

            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var department = _departmentService.GetDepartment(id);
            if (department == null)
                return NotFound();

            _departmentService.DeleteDepartment(department);
            return Ok();
        }
    }
}
