using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBitsAcademyEFC.Migrations;
using CodeBitsAcademyEFC.Models;
using CodeBitsAcademyEFC.ServiceRepository;
using Microsoft.AspNetCore.Mvc;

namespace CodeBitsAcademyEFC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartment _user;
        public DepartmentController(IDepartment user)
        {
            _user = user;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Department dept)
        {
            if (ModelState.IsValid)
            {
                _user.AddDept(dept);
                return RedirectToAction(nameof(Add));
            }
            else
            {
                return View();
            }
        }

        public IActionResult Department()
        {
            List<Department> debtList = new List<Department>();
            debtList = (from p in _user.Departments select p).ToList();
            debtList.Insert(0, new Department { DepartmentId = 0, DepartmentName = "Select" });
            ViewBag.ListofDebt = debtList;

            ViewBag.AllDepts = _user.Departments;
            return View();
        }

        

        public IActionResult de(Department dept)
        {
            ViewBag.AllDepts = _user.Departments;
            return View();
        }
    }
}