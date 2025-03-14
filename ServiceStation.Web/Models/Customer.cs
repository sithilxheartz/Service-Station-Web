using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Customer
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
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [StringLength(10)]
        [Required]
        public required string Phone { get; set; }
        public bool IsDeleted { get; set; }
        public required List<Vehicle> Vehicles { get; set; }
    }
}
