using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class FutureValidDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = true;
            try
            {
                var dateTime = DateTime.Parse((string) value);
                isValid = dateTime > DateTime.Now;
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