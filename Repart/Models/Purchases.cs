using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repart.Models
{
    public class Purchases
    {
        public int Id { get; set; }

        
        public Book Book { get; set; }
        [Required]
        public int BookId { get; set; }

        public Customer BuyersName { get; set; }
        [Required]
        public int BuyersNameId { get; set; }

        public DateTime DatePurchased { get; set; } 
    }
}