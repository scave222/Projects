using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OlanAcademy.Models;
using OlanAcademy.ServiceRepository;

namespace OlanAcademy.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _student;
        public StudentController(IStudent stu)
        {
            _student = stu;
        }
        public IActionResult List()
        {
            return View(_student.Students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _student.AddStudent(student);
                return RedirectToAction(nameof(Create));
            }
            else
            {
                return View();
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(long Id)
        {
            Student stud = _student.GetStudent(Id);
            if (stud == null)
            {
                return RedirectToAction("List");
            }
            return View(stud);
        }

        [HttpGet]
        public IActionResult DeleteConfirm(long Id)
        {
            Student stut = _student.GetStudent(Id);
            return View(stut);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(Student student, long Id)
        {
            _student.Delete(Id);
            return View("Success");
        }


        [HttpGet]
        public IActionResult Edit(long Id)
        {
            Student Edstu = _student.GetStudent(Id);
            return View(Edstu);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _student.EditStudent(student);
            return View("Success");
        }
        public IActionResult Success()
        {
            return View();
        }

    }
}