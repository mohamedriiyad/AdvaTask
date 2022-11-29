
using System.ComponentModel.DataAnnotations;

namespace AdvaTask.Domain.Models
{
    public class Employee : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
