﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class FutureValidDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/MM/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out var dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}