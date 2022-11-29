using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvaTask.Domain.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }

        public Employee Manager { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
