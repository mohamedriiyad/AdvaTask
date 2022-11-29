using System.ComponentModel.DataAnnotations;

namespace AdvaTask.Domain.Models
{
    public class Department : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int ManagerId { get; set; }

        public Employee Manager { get; set; }
    }
}
