using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

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

    public static class EnumExtensions
    {
        public static string GetDisplayName(this BloodType bloodType)
        {
            return bloodType.GetType()
                            .GetMember(bloodType.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }
}