using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ISignUpRepository _repository;

        private SignUpDbContext context { get; set; }

        // we decided to go with a db context instead of a repository, this is the old repository code
        //public HomeController(ILogger<HomeController> logger, ISignUpRepository repository)
        //{
        //    _logger = logger;
        //    _repository = repository;
        //    context = application.ApplicationServices.
        //        //CreateScope().ServiceProvider.GetRequiredService<SignUpDbContext>();
        //}

        //constructor for the HomeController. Establish context to database and initialize TourTimes object
        public HomeController(SignUpDbContext con)
        {
            context = con;
            TourTimes tourTimes = new TourTimes();
        }

        public IActionResult Index()
        {
            return View(context.Projects);
        }
        //IActionResult below will be used when the signup form is submitted. It will save the signup in the database, and update the TourTime to be taken.
        [HttpPost]
        public IActionResult Index(Project newProj)
        {
            if (ModelState.IsValid)
            {
                //_repository.Projects.Add(newProj);
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
