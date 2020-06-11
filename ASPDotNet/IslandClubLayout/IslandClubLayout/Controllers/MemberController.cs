using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IslandClubLayout.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Privacy.cshtml");
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }
    }
}