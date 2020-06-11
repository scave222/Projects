using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Models;


namespace Model.Controllers
{
    public class MoviesController : Controller
    {
        

        public IActionResult Details()
        {
            Array array;

            List<MoviesModelArray> movies = new List<MoviesModelArray>();

            //Add record 1
            movies.Add(new MoviesModelArray
            {
                MovieName = "Fast n Furious",
                MovieType = "Action",
                YearRelease = "2019"
            });
            //Add record 2
            movies.Add(new MoviesModelArray
            {
                MovieName = "Saving Private Ryan",
                MovieType = "Comedy",
                YearRelease = "2020",
            });
            //Add record 3
            movies.Add(new MoviesModelArray
            {
                MovieName = "Dared Devil",
                MovieType = "Action",
                YearRelease = "2015",
            });
            //Add record 4
            movies.Add(new MoviesModelArray
            {
                MovieName = "Into the bad lands",
                MovieType = "Action",
                YearRelease = "2017",
            });
            //Add record 5
            movies.Add(new MoviesModelArray
            {
                MovieName = "Three Idiots",
                MovieType = "Education",
                YearRelease = "2010",
            });

            //Convert the List to array and assign its value to the array variable
            array = movies.ToArray();

            //Assign the value of the array to a employee view bag
            ViewBag.Movies = array;
            ViewData["ServerTime"] = DateTime.Now;
            return View();

            

        }
    }
}