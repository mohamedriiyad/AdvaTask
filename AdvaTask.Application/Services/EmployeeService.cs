using AdvaTask.Application.Interfaces;
using AdvaTask.Domain.Interfaces;
using AdvaTask.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvaTask.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddEmployee(Employee employee)
        {
            _unitOfWork.Employees.Add(employee);
            _unitOfWork.Complete();
        }

        public void DeleteEmployee(Employee employee)
        {
            _unitOfWork.Employees.Delete(employee);
            _unitOfWork.Complete();
        }

        public IEnumerable<Employee> GetEmployeesWithManagersAndDepartments()
        {
            return _unitOfWork.Employees.GetAll(new[] { "Department" });
        }

        public Employee GetEmployeeWithManagerAndDepartmentById(int id)
        {
            return _unitOfWork.Employees.Find(e => e.Id == id, new[] { "Department" });
        }

        public void UpdateEmployee(Employee employee)
        {
            _unitOfWork.Employees.Update(employee);
            _unitOfWork.Complete();
        }
    }
}
