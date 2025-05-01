using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.DTO
{
	public class BookDTO
	{
        
        public int Bookid { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public int CatogoryID { get; set; }
        public int Qty { get; set; }
    }
}