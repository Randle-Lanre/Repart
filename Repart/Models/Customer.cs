using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repart.Models
{
    public class Customer
    {
        public String CustomerName { get; set; }
        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool CustomerSubscribedToNewsletter { get; set; }
    }
}