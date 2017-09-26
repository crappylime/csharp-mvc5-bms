using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Core.Models
{
    public enum BloodType
    {
        [Display(Name = "A Rh+")]
        A_Rh_plus = 1,

        [Display(Name = "A Rh-")]
        A_Rh_minus = 2,

        [Display(Name = "B Rh+")]
        B_Rh_plus = 3,

        [Display(Name = "B Rh-")]
        B_Rh_minus = 4,

        [Display(Name = "AB Rh+")]
        AB_Rh_plus = 5,

        [Display(Name = "AB Rh-")]
        AB_Rh_minus = 6,

        [Display(Name = "0 Rh+")]
        O_Rh_plus = 7,

        [Display(Name = "0 Rh-")]
        O_Rh_minus = 8
    }
}