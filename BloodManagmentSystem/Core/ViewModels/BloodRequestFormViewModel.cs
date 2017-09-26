using BloodManagmentSystem.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class BloodRequestFormViewModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select type")]
        public BloodType BloodType { get; set; }

        [Required]
        [FutureValidDate]
        public string Date { get; set; }

        [IsTimeValid]
        public string Time { get; set; }

        [Required]
        public int Bank { get; set; }

        public string City { get; set; }
        public IEnumerable Banks { get; set; }

        public BloodRequestFormViewModel()
        {
            Banks = new List<BloodBank>();
        }

        public DateTime GetDueDateTime()
        {
            if (string.IsNullOrWhiteSpace(Time))
                Time = "12:00";
            return DateTime.Parse($"{Date} {Time}");
        }
    }
}