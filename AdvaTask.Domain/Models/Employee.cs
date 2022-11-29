
using System.ComponentModel.DataAnnotations;

namespace AdvaTask.Domain.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Department Department { get; set; }
    }
}
