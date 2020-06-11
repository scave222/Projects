using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCVideoDemo.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public string Hello()
        {
            return "Hello caleb";
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public  ViewResult hey()
        {
           
            return View();
        }
    }
}