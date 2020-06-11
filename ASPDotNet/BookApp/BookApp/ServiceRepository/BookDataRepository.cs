using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Models;

namespace BookApp.ServiceRepository
{
    public class BookDataRepository : IBook
    {
        //Create DataStorage using List -- In -Memory
        private readonly List<Book> data = new List<Book>();

        //Implement  Book method from interface
        //public IEnumerable<Book> Books
        //{
        //    get
        //    {
        //        return data;
        //    }
        //}     AKA
        public IEnumerable<Book> Books => data;

        //Implement  AddBook method from interface
        public void AddBook(Book book)
        {
            this.data.Add(book);
        }
    }
}

