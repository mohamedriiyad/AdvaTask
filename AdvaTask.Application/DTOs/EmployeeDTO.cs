using System.ComponentModel.DataAnnotations;

namespace AdvaTask.Application.DTOs
{
    public class EmployeeDTO
    {
        [Required]
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}