using AdvaTask.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvaTask.Application.Interfaces
{
    public interface IDepartmentService
    {
        void AddDepartment(Department department);
        Department GetDepartment(int id);
        IEnumerable<Department> GetDepartments();
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);
        bool IsDepartmentManagerExists(int id);
    }
}
