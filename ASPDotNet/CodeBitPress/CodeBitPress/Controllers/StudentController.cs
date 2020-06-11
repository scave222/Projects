using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBitPress.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeBitPress.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Details()
        {
           // ViewBag.Title = "Student Details Page";
            //ViewBag.Header = "Student Details";
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 100,
                Name = "Abayomi",
                DateOfBirth = "20-10-1986",
                Gender = "Male",
            };

            //Address Details
            Address address = new Address()
            {
                StudentId = 100,
                City = "Ota",
                State = "Abeokuta",
                Country = "Nigeria",
            };
            //ViewModel for StudentAddress
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };

            //Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }
    }
}