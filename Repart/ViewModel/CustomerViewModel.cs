using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repart.Models;

namespace Repart.ViewModel
{
    public class CustomerViewModel
    {
        public List<Book> Books { get; set; }
        public List<Customer> Customers { get; set; }
    }
}