using System.ComponentModel.DataAnnotations;
using BloodManagmentSystem.Core.Models;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class DonorFormViewModel
    {
        [Required(ErrorMessage = "Enter your name, please.")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Name cannot be longer than 50 characters and less than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email, please.")]
        [EmailAddress(ErrorMessage = "Enter valid email, please.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your city, please.")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "City cannot be longer than 50 characters and less than 3 characters")]
        public string City { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Choose your blood type, please.")]
        public BloodType BloodType { get; set; }
    }
}