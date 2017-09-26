using BloodManagmentSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class BloodRequestFormViewModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "Select type")]
        public BloodType BloodType { get; set; }

        public DateTime DueDate { get; set; }
        public int Bank { get; set; }
        public string City { get; set; }
        public IEnumerable<BloodBank> Banks { get; set; }
    }
}