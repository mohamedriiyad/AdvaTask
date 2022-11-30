﻿using System.ComponentModel.DataAnnotations;

namespace AdvaTask.Application.DTOs.Departments
{
    public class DepartmentDTO
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int ManagerId { get; set; }
    }
}
