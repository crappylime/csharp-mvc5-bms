using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodManagmentSystem.Core.Models
{
    public class Confirmation
    {
        [Key]
        [Column(Order = 1)]
        public int RequestId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int DonorId { get; set; }

        public BloodRequest Request { get; set; }
        public Donor Donor { get; set; }
        public string HashCode { get; set; }
        public bool Status { get; set; }
    }
}