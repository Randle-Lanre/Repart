using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repart.Models;
using Repart.ViewModel;

//controller for handling book related activities
namespace Repart.Controllers
{
    public class BooksController : Controller
    {
        //get the application dbcontext for the domain class
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context= new ApplicationDbContext();
        }


        // GET: Books
        public ActionResult Index()
        {
            //dummy populate customers and books
            var dummyBooks= new List<Book>
            {
                new Book
                {
                    BookName = "48 Laws of power", 
                    Author = "Robert greene"
                },
                new Book
                {
                    BookName=" 15 days in a war zone",
                    Author = "unknown author"
                },
                new Book
                {
                    BookName ="Animal Farm",
                    Author = "Unknown Author"

                },
                new Book
                {
                    BookName = "Cracking the coding interview", 
                    Author = "unknown author"
                }


    
            };

            var customerNames= new List<Customer>
            {
                new Customer
                {
                    CustomerName = "Mike tyson", 
                    CustomerSubscribedToNewsletter = false,

                    

                    DateOfBirth = new DateTime(2016, 05,04)

                },
                new Customer
                {
                    CustomerName = "Donald Trump", CustomerSubscribedToNewsletter = true, 
                    DateOfBirth = new DateTime(2018, 06, 3)

                }
            };

            var customerViewModel = new CustomerViewModel
            {
                Customers = customerNames,
                Books = dummyBooks
            };
            
            return View("ListOfBooks", customerViewModel);
        }

        //add new movies to the list already present 
        //[HttpPost]
        //[Authorize(Roles = RolePriviledge.canAddBooks)]
        public ActionResult New()
        {
            return View();
        }

        //TODO: fix bug with posting new data to the server
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
                return View("New");


            if (book.Id == 0)
            {
                _context.Books.Add(book);
            }
            else
            {
                var booksInDatabase = _context.Books.Single(b => b.Id == book.Id);
                booksInDatabase.Author = book.Author;
                booksInDatabase.BookName = book.BookName;
                booksInDatabase.Available = book.Available;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Books");




        }

        //delete a set of movies 
        //TODO: add use either roles or users to filter down who can make changes
        //[Authorize(Roles = RolePriviledge.CanDeleteBooks)]
        public ActionResult Delete()
        {
            return View();
        }
    }
}