using AdvaTask.Application.DTOs.Employees;
using AdvaTask.Application.Interfaces;
using AdvaTask.Domain.Interfaces;
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
        private readonly IUnitOfWork _unitOfWork;

        public EmployeesController(IEmployeeService employeeService,
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            _employeeService = employeeService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
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
            if (employeeDTO.DepartmentId == 0)
                employee.DepartmentId = null;

            _employeeService.AddEmployee(employee);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpPut("edit")]
        public IActionResult Edit(EditEmployeeDTO employeeDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var employee = _mapper.Map<Employee>(employeeDTO);
            if (employeeDTO.DepartmentId == 0)
                employee.DepartmentId = null;
            
            _employeeService.UpdateEmployee(employee);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            if (employee == null)
                return NotFound();

            _employeeService.DeleteEmployee(employee);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
