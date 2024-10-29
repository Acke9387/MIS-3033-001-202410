using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApplication.Models;


namespace MyFirstMVCApplication.Controllers
{
    public class DeveloperInfoController : Controller
    {
        public IActionResult Index()
        {
            DeveloperInformation developerInformation = new DeveloperInformation();
            developerInformation.Name = "Professor Ackerman";
            developerInformation.Email = "adam@ou.edu";
            developerInformation.PhoneNumber = "405-325-4358";

            return View(developerInformation);
        }
    }
}
