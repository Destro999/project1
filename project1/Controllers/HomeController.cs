using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using project1.Models.ViewModels;

namespace project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SignUpDbContext context { get; set; }

        private TourTimes tourTimes { get; set; }

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
      
       
        //IActionResult below is used to list all the time slots available to sign up for, so Nick can use it for the SignUp page
        public IActionResult SignUp()
        {
            foreach (var proj in context.Projects)
            {
                tourTimes.TimeSlots.RemoveAll(r => r.Time == proj.DayTime);
            }
            return View("SignUp", tourTimes);
        }

        //IACTION below takes the time from the button and sets it to an IndexView Model before passing it to the Appointment Details page
        [HttpPost]
        public IActionResult SignUp(string time)
        {
            return View("AppointmentDetails", new IndexViewModel
            {
                Time = time
            });
        }

        //Takes the information from the form and sets it into a Project object and saves it to the DBContext
        [HttpPost]
        public IActionResult AppointmentDetails(string groupName, int groupSize, string dayTime, string emailAddress, long phoneNumber)
        {
            if (ModelState.IsValid)
            {
                Project newProj = new Project
                {
                    GroupName = groupName,
                    GroupSize = groupSize,
                    DayTime = dayTime,
                    EmailAddress = emailAddress,
                    PhoneNumber = phoneNumber
                };
                context.Projects.Add(newProj);
                context.SaveChanges();
            }

            return View("ViewAppointments", context.Projects) ;
        }

        //Sends it to the AppointmentDetails page
        public IActionResult AppointmentDetails()
        {
            return View();
        }

        //Sends to ViewAppointment page
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
