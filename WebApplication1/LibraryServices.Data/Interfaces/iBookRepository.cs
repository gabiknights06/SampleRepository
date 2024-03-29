﻿using LibraryServices.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Data.Interfaces
{
    public interface iBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int Id);
    }
}
