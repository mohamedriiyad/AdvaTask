using AdvaTask.Application.DTOs;
using AdvaTask.Application.Interfaces;
using AdvaTask.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdvaTask.WebUI.Controllers
{
    public class EmployeesController : BaseController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("get/{id}")]
        public Employee Get(int id) => _employeeService.GetEmployeeWithManagerAndDepartmentById(id);

        [HttpGet("get")]
        public IEnumerable<Employee> Get() =>_employeeService.GetEmployeesWithManagersAndDepartments();

        [HttpPost("create")]
        public IActionResult Create(AddEmployeeDTO employeeDTO) {
            return Ok();
        } 


    }
}
