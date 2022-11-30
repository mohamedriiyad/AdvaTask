using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdvaTask.Application.DTOs
{
    public class AddEmployeeDTO
    {
        [Required]
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}
