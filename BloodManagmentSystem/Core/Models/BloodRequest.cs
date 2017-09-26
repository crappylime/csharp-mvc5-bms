using System;
using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Core.Models
{
    public class BloodRequest
    {
        public int Id { get; private set; }

        [Required]
        public BloodType BloodType { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [Required]
        public int BankId { get; set; }

    }
}