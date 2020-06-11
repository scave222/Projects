using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Models;

namespace BookApp.ServiceRepository
{
    public interface IBook
    {
        IEnumerable<Book> Books { get; }
        public void AddBook(Book book);
    }
}
