using AdvaTask.Application.DTOs;
using AdvaTask.Application.Interfaces;
using AdvaTask.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdvaTask.WebUI.Controllers
{
    public class EmployeesController : BaseController
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet("get/{id}")]
        public Employee Get(int id) => _employeeService.GetEmployeeWithManagerAndDepartmentById(id);

        [HttpGet("get")]
        public IEnumerable<Employee> Get() =>_employeeService.GetEmployeesWithManagersAndDepartments();

        [HttpPost("create")]
        public IActionResult Create(AddEmployeeDTO employeeDTO) 
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var employee = _mapper.Map<Employee>(employeeDTO);
            _employeeService.AddEmployee(employee);

            return Ok();
        }

        [HttpPut("edit")]
        public IActionResult Edit(EditEmployeeDTO employeeDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var employee = _mapper.Map<Employee>(employeeDTO);
            _employeeService.UpdateEmployee(employee);

            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            if (employee == null)
                return NotFound();

            _employeeService.DeleteEmployee(employee);
            return Ok();
        }
    }
}
