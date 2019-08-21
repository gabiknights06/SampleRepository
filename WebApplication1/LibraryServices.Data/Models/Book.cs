using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryServices.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Publication_Year { get; set; }
        public bool isAvailable { get; set; }

    }
}