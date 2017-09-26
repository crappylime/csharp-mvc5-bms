using BloodManagmentSystem.Core.Models;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class BloodRequestFormViewModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select type")]
        public BloodType BloodType { get; set; }

        [Required]
        public string Date { get; set; }

        public string Time { get; set; }

        [Required]
        public int Bank { get; set; }

        public string City { get; set; }
        public IEnumerable Banks { get; set; }

        public DateTime GetDueDateTime()
        {
            return DateTime.Parse($"{Date} {Time}");
        }
    }
}