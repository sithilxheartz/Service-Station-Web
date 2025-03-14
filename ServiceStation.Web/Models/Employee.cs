using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ServiceStation.Web.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("First Name")]
        [StringLength(50)]
        [Required]
        public required string FirstName { get; set; }
        [DisplayName("Last Name")]
        [StringLength(50)]
        [Required]
        public required string LastName { get; set; }
        [StringLength(10)]
        [Required]
        public required string Phone { get; set; }
        public bool IsDeleted { get; set; }
    }
}
