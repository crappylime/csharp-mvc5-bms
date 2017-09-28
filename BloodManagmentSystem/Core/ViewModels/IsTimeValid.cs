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

            //var isValid = DateTime.TryParseExact(Convert.ToString(value),
            //    "HH:mm",
            //    CultureInfo.CurrentCulture,
            //    DateTimeStyles.None,
            //    out var dateTime);
            bool isValid = true;
            try
            {
                var x = (DateTime) value;
            }
            catch (Exception e)
            {
                isValid = false;
                Console.WriteLine(e);
                throw;
            }
            return isValid;
        }
    }
}