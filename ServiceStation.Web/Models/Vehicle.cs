using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Vehicle
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public required string Model { get; set; }

        [Required]
        public string LicenseNumber{ get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public required string Color { get; set; }
        public bool IsDeleted { get; set; }
        public required string CustomerId { get; set; }
    }
}
