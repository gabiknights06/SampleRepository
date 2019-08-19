using LibraryServices.Data.Interfaces;
using LibraryServices.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Data.Repositories
{
    public class BookRepository : iBookRepository
    {

        public List<Book> books = new List<Book>()
        {
           new Book { Id = 1, Author = "Author 1", Title = "Book 1",  Publication_Year = 2001 },
           new Book { Id = 2, Author = "Author 2", Title = "Book 2",  Publication_Year = 2002 },
           new Book { Id = 3, Author = "Author 3", Title = "Book 3",  Publication_Year = 2003 },
           new Book { Id = 4, Author = "Author 4", Title = "Book 4",  Publication_Year = 2004 },
           new Book { Id = 5, Author = "Author 5", Title = "Book 5",  Publication_Year = 2005 }

        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int Id)
        {
            var book = books.FirstOrDefault(x => x.Id == Id);
            return book;
        }
    }
}
