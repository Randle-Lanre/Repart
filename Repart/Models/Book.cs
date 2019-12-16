using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repart.Models
{
    public class Book
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Book Name")]
        public String BookName { get; set; }
        
        public String Author { get; set; }

        [Required]
        public bool Available { get; set; }

        public int Id { get; set; }


        
    }
}