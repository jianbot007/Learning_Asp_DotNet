using LMS.DTO;
using LMS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class BookController : Controller
    {


        private LibaryManagementEntities db = new LibaryManagementEntities();
        // GET: Book
        public ActionResult Index()
        {
            var data = db.Books.ToList();

            return View(BookController.Convert(data));
        }

        public ActionResult Select(int id)
        {
            var b = db.Books.Find(id);
            if (b.Qty > 0)
            {
                List<BookDTO> cart = null;
                if (Session["cart"] == null)
                {
                    cart = new List<BookDTO>();
                }
                else
                {
                    cart = (List<BookDTO>)Session["cart"];
                }


                b.Qty = b.Qty - 1;

                db.SaveChanges();
                cart.Add(Convert(b));
                Session["cart"] = cart;
                TempData["msg"] = "Added to Cart";
            }
            else
            {
                TempData["Failed"] = "no Quantity left for this Book";
            }
                return RedirectToAction("Index");
            
        }

        public static BookDTO Convert(Book b)
        {
            return new BookDTO()
            {
                CatogoryID = b.CatogoryID,
                Author = b.Author,
                BookName = b.BookName,
                Bookid = b.Bookid,
                Qty = b.Qty
            };

        }
        public static Book Convert(BookDTO b)
        {
            return new Book()
            {
                CatogoryID = b.CatogoryID,
                Author = b.Author,
                BookName = b.BookName,
                Bookid = b.Bookid,
                Qty = b.Qty
            };

        }
        public static List<BookDTO> Convert(List<Book> books)
        {
            var Books = new List<BookDTO>();
            foreach(var book in books)
            {
                Books.Add(Convert(book));
            }
            return Books;
        }


    }
}