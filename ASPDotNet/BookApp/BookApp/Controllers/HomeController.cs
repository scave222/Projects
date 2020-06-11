using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookApp.Models;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterBook(Book bookResponse)
        {
            //No Dependency Injection
            //Therefore our application will be tightly coupled because the
            //HomeController class is now tightly coupled with the BookRepository class
            if (ModelState.IsValid)
            {
                BookRepository.AddBook(bookResponse);
                return View("Thank",bookResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult Lists()
        {
            return View(BookRepository.Books.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
