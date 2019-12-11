using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repart.Controllers
{
    public class HomeController : Controller
    {
        /*
         * repart book store app would have the following
         * there would be a list of books
         * users can buy such books (select and click add to add to his or her account)
         * on each purchase or collection by the user user the total number of books would be reduced(the
         * particular variety of the book)
         * the would be an admin(individuals designated as admin), would can add to the quantity of the books or remove
         * and can also even remove the listing of the books
         *
         *model:    books, customers, genre (TODO: set relationships )
         * add Age restriction, i.e some books are available to people only over 18 years of age
         *
         *navbar would be (customers, books )
         *
         */
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}