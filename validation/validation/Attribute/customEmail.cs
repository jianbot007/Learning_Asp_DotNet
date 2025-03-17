using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace validation.Attribute
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using validation.Models;

    public class MatchEmailWithIdAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (Student)validationContext.ObjectInstance;


            if (!user.Email.StartsWith(user.Id))
            {
                return new ValidationResult("Email must start with the same ID.");
            }
            else
            {
                return new ValidationResult("Sucess");
            }

                return ValidationResult.Success;
        }
    }

}