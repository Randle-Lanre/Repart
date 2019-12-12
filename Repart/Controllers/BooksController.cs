using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repart.Models;

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
            if
            return View();
        }
    }
}