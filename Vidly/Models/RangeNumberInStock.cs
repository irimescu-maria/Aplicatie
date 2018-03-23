﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class RangeNumberInStock :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock == 0)
                return new ValidationResult("The field Number in Stock must be between 1 and 20.");
            var range = movie.NumberInStock;
            return (range >= 1 && range <= 20)
                ? ValidationResult.Success
                : new ValidationResult("The field Number in Stock must be between 1 and 20.");
        }
    }
}