using LibraryServices.Data.Interfaces;
using LibraryServices.Data.Models;
using LibraryServices.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;

namespace WebApplication1.Controllers
{
    public class BookController : ApiController
    {

        //private iBookRepository books = new BookRepository(); // using this we will no longer needed a contructor

        //everytime we use interface, we should always create a contructor
        private iBookRepository books; //interface
        //constructor for the interface
        public BookController(iBookRepository _books)
        {
            this.books = _books;
        }

        // GET api/book

        public IEnumerable<Book> Get()
        {
            return books.GetAllBooks();
        }

        // GET api/book/5
        public IHttpActionResult Get(int id)
        {
            var book = books.GetBook(id);
            if(book == null)
            {
                return NotFound();
            }
            else
            {
               return Ok(book);
            }
        }
    }
}
