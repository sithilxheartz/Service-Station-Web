using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Transaction
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int VehicleId { get; set; }
        public DateTime TransactionDate { get; set; }
        [Required]
        public TransactionStatus Status { get; set; } = TransactionStatus.New;
        public bool IsDeleted { get; set; }
    }
}
