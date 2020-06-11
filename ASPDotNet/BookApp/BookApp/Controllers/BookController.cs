using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookApp.Models;
using BookApp.ServiceRepository;

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        public readonly IBook _book;
        public BookController(IBook bk)
        {
            _book = bk;
        }
        public IActionResult Index()
        {
            return View(_book.Books);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _book.AddBook(book);
                return View("Thank", book);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
    }
}