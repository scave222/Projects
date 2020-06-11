using CodeBitsPublisher.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace CodeBitsPublisher.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<Publishers> listPublishers = new List<Publishers>()
            {
            new Publishers() { PublisherId = 111, PublisherName = "Unilag Press", Phone = "0904-678-6786", Address = "Shomolu, Bariga", City = "Shomolu" },
            new Publishers() { PublisherId = 112, PublisherName = "Ota Press", Phone = "0802-678-4566", Address = "Iju Atan Road", City = "Ota" },
            new Publishers() { PublisherId = 113, PublisherName = "Etim Press Ltd", Phone = "0705-234-7843", Address = "Sabo Bus Stop, Yaba", City = "Lagos" },
            new Publishers() { PublisherId = 114, PublisherName = "AY Publisher", Phone = "0804-678-5467", Address = "Itire Surulere", City = "Surulere" },
            new Publishers() { PublisherId = 115, PublisherName = "Oyo Press", Phone = "0904-678-6786", Address = "Apata Road", City = "Apata" }
            };
            return View(listPublishers);
        }
        public ViewResult Details(int Id)
        {
            var PublisherDetails = new Publishers() { PublisherId = 111, PublisherName = "Ota Press", Phone = "0802-678-4566", Address = "Iju Atan Road", City = "Ota" };
            return View(PublisherDetails);
        }
    }
}
