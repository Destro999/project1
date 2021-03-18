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
        private SignUpDbContext context { get; set; }

        private TourTimes tourTimes { get; set; }

        // we decided to go with a db context instead of a repository, this is the old repository code
        //--------------------------------------------------------------------------------------------
        //private readonly ILogger<HomeController> _logger;
        //private ISignUpRepository _repository;
        //public HomeController(ILogger<HomeController> logger, ISignUpRepository repository)
        //{
        //    _logger = logger;
        //    _repository = repository;
        //    context = application.ApplicationServices.
        //        //CreateScope().ServiceProvider.GetRequiredService<SignUpDbContext>();
        //}

        //constructor for the HomeController. Establish context to database and initialize TourTimes object
        public HomeController(ILogger<HomeController> logger, SignUpDbContext con)
        {
            _logger = logger;
            context = con;
            tourTimes = new TourTimes();
        }

        //default IActionResult for index view when you pull up the website
        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Projects);
        }
        //IActionResult below will be used when the signup form is submitted. It will save the signup in the database, and update the TourTime to be taken.
        [HttpPost]
        public IActionResult Add(Project newProj)
        {
            if (ModelState.IsValid)
            {
                context.Projects.Add(newProj);
                tourTimes.UpdateTimeSlot(newProj.DayTime, false); //Brandon is going to add the DayAndTime attribute to this class
                context.SaveChanges();
            }
            return View();
        }
       
        //IActionResult below is used to list all the time slots available to sign up for, so Nick can use it for the SignUp page
        public IActionResult SignUp()
        {
            return View("SignUp", tourTimes);
        }
        //IActionResult below us used to get to the form, from the SignUp page that lists all the time slots
        [HttpPost]
        public IActionResult SignUp(string time)
        {
            return View("AppointmentDetails", time);
        }

        public IActionResult ViewAppointments()
        {
            return View(context.Projects);
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
