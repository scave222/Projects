using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBitsAcademyEFC.Models;
using CodeBitsAcademyEFC.ServiceRepository;
using Microsoft.AspNetCore.Mvc;
using CodeBitsAcademyEFC.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CodeBitsAcademyEFC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;
        private readonly IWebHostEnvironment hostingEnvironment; 
        public EmployeeController(IEmployee emp,
            IWebHostEnvironment hostingEnvironment)
        {
            _employee = emp;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult List()
        {
            return View(_employee.Employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.Photo != null)
                {
                  string uploadsFolder =  Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                   string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Employee newEmployee = new Employee
                {//C:\codebits-academy\ASPDotNet\CodeBitsAcademyEFC\CodeBitsAcademyEFC\wwwroot\images\2018-07-08-08-46-18-717 - Copy.jpg
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Age = model.Age,
                    Gender = model.Gender,
                    Email = model.Email,
                    HomeAddress = model.HomeAddress,
                    PhoneNumber = model.PhoneNumber,
                    PhotoPath = uniqueFileName
                };
                _employee.AddEmployee(newEmployee);
               // _employee.AddEmployee(employee);
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
            Employee empl = _employee.GetEmployee(Id);
            if(empl == null)
            {
                return RedirectToAction("List");
            }
            return View(empl);
        }

        [HttpGet]
        public IActionResult DeleteConfirm(long Id)
        {
            Employee emp = _employee.GetEmployee(Id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(Employee employee, long Id)
        {
            _employee.Delete(Id);
            return View("Success");
        }

        
        [HttpGet]
        public IActionResult Edit(long Id)
        {
            Employee Edemp = _employee.GetEmployee(Id);
            return View(Edemp);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employee.EditEmployee(employee);
            return View("Success");
        }

        public IActionResult Success()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Search()
        {
            //Employee person = _employee.GetEmployee(Id);
            return View();
        }

        [HttpPost]
        public IActionResult Search(string FName)
        {

            var result = _employee.Search(FName);
            return View("SearchResult",result);

        }
        
        
        
    }
}