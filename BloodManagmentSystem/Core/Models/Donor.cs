﻿namespace BloodManagmentSystem.Core.Models
{
    public class Donor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public BloodType BloodType { get; set; }
    }
}