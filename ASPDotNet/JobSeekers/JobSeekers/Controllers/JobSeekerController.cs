using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSeekers.Models;
using JobSeekers.ServiceRepository;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekers.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly IJobSeeker _seekers;

        public JobSeekerController(IJobSeeker seek)
        {
            _seekers = seek;
        }
        public IActionResult List()
        {
            return View(_seekers.Jobseek);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(JobSeeker see)
        {
            if (ModelState.IsValid)
            {
                _seekers.AddJobSeeker(see);
                return RedirectToAction(nameof(Create));
            }
            else
            {
                return View();
            }
        }
        public IActionResult Details(long Id)
        {
           JobSeeker seek = _seekers.GetJobSeeker(Id);
            if (seek == null)
            {
                return RedirectToAction("List");
            }
            return View(seek);
        }
        [HttpGet]
        public IActionResult DeleteConfirm(long Id)
        {
            JobSeeker seek = _seekers.GetJobSeeker(Id);
            return View(seek);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(JobSeeker seeker, long Id)
        {
            _seekers.Delete(Id);
            return View("Success");
        }
        [HttpGet]
        public IActionResult Edit(long Id)
        {
            JobSeeker see = _seekers.GetJobSeeker(Id);
            return View(see);
        }
        [HttpPost]
        public IActionResult Edit(JobSeeker seek)
        {
            _seekers.EditJobSeeker(seek);
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

            var result = _seekers.Search(FName);
            return View("SearchResult", result);

        }
    }
}