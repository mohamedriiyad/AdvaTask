using AdvaTask.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvaTask.Application.Interfaces
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        Employee GetEmployee(int id);
        Employee GetEmployeeWithManagerAndDepartmentById(int id);
        IEnumerable<Employee> GetEmployeesWithManagersAndDepartments();
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
