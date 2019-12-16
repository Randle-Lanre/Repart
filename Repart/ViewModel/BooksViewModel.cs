using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Repart.Models;

namespace Repart.ViewModel
{
    public class BooksViewModel
    {

        [Required]
        [StringLength(255)]
        [Display(Name = "Book Name")]
        public String BookName { get; set; }

        public String Author { get; set; }

        [Required]
        public bool Available { get; set; }

        //public int? Id { get; set; }

        //public BooksViewModel()
        //{
        //    Id = 0;
        //}

        //public BooksViewModel( Book book)
        //{
        //    Id = book.Id;
        //    BookName = book.BookName;
        //    Available = book.Available;
        //    Author = book.Author;

        //}
    }
}