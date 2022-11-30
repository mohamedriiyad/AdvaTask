using AdvaTask.Application.Interfaces;
using AdvaTask.Domain.Interfaces;
using AdvaTask.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvaTask.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddDepartment(Department department)
        {
            _unitOfWork.Departments.Add(department);
            _unitOfWork.Complete();
        }

        public void DeleteDepartment(Department department)
        {
            _unitOfWork.Departments.Delete(department);
            _unitOfWork.Complete();
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _unitOfWork.Departments.GetAll(new[] { "Manager" });
        }

        public Department GetDepartment(int id)
        {
            return _unitOfWork.Departments.Find(d => d.Id == id, new[] { "Manager" });
        }

        public void UpdateDepartment(Department department)
        {
            _unitOfWork.Departments.Update(department);
            _unitOfWork.Complete();
        }
    }
}
