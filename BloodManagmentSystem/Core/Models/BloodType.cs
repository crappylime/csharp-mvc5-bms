using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Core.Models
{
    public enum BloodType
    {
        [Display(Name = "ARh+")]
        A_Rh_plus = 1,

        [Display(Name = "ARh-")]
        A_Rh_minus = 2,

        [Display(Name = "BRh-")]
        B_Rh_plus = 3,

        [Display(Name = "BRh+")]
        B_Rh_minus = 4,

        [Display(Name = "ABRh-")]
        AB_Rh_plus = 5,

        [Display(Name = "ABRh+")]
        AB_Rh_minus = 6,

        [Display(Name = "0Rh-")]
        O_Rh_plus = 7,

        [Display(Name = "0Rh+")]
        O_Rh_minus = 8
    }
}