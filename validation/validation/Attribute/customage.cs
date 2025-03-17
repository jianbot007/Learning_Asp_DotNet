using System;
using System.ComponentModel.DataAnnotations;

public class MinAgeAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;


            if (age >= 18)
            {
                return new ValidationResult("success");
            }
            else
            {
                return new ValidationResult($"Age must be at least 18 years.");
            }
        }
        return new ValidationResult("Invalid date format.");
    }
}
