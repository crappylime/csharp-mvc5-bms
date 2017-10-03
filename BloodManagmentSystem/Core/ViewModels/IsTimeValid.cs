using System;
using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class IsTimeValid : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            var isValid = true;
            try
            {
                var x = DateTime.Parse(value.ToString()).TimeOfDay;
            }
            catch (Exception e)
            {
                isValid = false;
                Console.WriteLine(e);
            }
            return isValid;
        }
    }
}