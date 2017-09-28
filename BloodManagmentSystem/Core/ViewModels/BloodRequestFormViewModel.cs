using BloodManagmentSystem.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class BloodRequestFormViewModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select type")]
        public BloodType BloodType { get; set; }

        [Required]
        [FutureValidDate]
        public DateTime DueDate { get; set; }

        [IsTimeValid]
        public DateTime Time { get; set; }

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
            return DueDate.Date.Add(Time.TimeOfDay);
        }
    }
}