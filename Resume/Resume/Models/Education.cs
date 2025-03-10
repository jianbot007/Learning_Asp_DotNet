using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
	public class Education
	{
        public string Degree { get; set; }
        public string Institute { get; set; }
        public float Cgpa  { get; set; }
        public int Year { get; set; }
    }
}