using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using CodeBitsAcademyEFC.Models;
using CodeBitsAcademyEFC.ServiceRepository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CodeBitsAcademyEFC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISystemUsers _user;
        private readonly IDepartment debt;
        public AccountController(ISystemUsers user, IDepartment db)
        {
            _user = user;
            debt = db;
        }
        public IActionResult List()
        {
            return View(_user.SystemUsers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(SystemUsers see)
        {
            
            //ViewBag.AllDepts = debt.Departments;

            if (ModelState.IsValid)
            {
                _user.AddUsers(see);
                return RedirectToAction(nameof(Create));
            }
            else
            {
                return View();
            }
        }
        public IActionResult Details(long Id)
        {
            SystemUsers user = _user.GetUsers(Id);
            if (user == null)
            {
                return RedirectToAction("List");
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult DeleteConfirm(long Id)
        {
            SystemUsers use = _user.GetUsers(Id);
            return View(use);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(SystemUsers employee, long Id)
        {
            _user.Delete(Id);
            return View("Success");
        }
        [HttpGet]
        public IActionResult Edit(long Id)
        {
            SystemUsers use = _user.GetUsers(Id);
            return View(use);
        }
        [HttpPost]
        public IActionResult Edit(SystemUsers user)
        {
            _user.EditUsers(user);
            return View("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string Name, long Id)
        {

            var result = _user.Search(Name, Id);
            return View("SearchResult", result);

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var ans = _user.Login(username, password);
            HttpContext.Session.SetString("Username", username);
            ViewBag.Message = HttpContext.Session.GetString("Username");

            if (ans)
            {
                return View("loginsucceed");
            }
            else {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
            
             
        }
    }
}