using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using validation.Attribute;



namespace validation.Models
{
	public class Student
	{
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "ID format must be XX-XXXXX-X")]
        public String Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name must not exceed 100 characters")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [MatchEmailWithId]
        public string Email { get; set; }
        [Required]
        [MinAge()]
        public DateTime Dob { get; set; }
    }
}
