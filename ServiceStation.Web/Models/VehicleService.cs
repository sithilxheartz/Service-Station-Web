using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class VehicleService
    {
        [Required]
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public decimal Cost { get; set; }
        public bool IsDeleted { get; set; }



    }

}
