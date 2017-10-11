using System;

namespace BloodManagmentSystem.Core.Models
{
    public class BloodRequest
    {
        public int Id { get; private set; }
        public BloodType BloodType { get; set; }
        public DateTime DueDateTime { get; set; }
        public string City { get; set; }
        public BloodBank Bank { get; set; }
        public int BankId { get; set; }
    }
}