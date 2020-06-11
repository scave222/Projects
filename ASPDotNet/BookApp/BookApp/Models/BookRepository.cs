using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class BookRepository
    {
        private static readonly List<Book> BooksListDB = new List<Book>();
        public static IEnumerable<Book> Books
        {
            get
            { 
                return BooksListDB;
            }
        }

        public static void AddBook(Book book)
        {
                BooksListDB.Add(book);
        }
    }
}
