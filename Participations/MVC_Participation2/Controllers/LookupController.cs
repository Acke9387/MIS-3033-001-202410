using Microsoft.AspNetCore.Mvc;
using MVC_Participation2.Models;
using Newtonsoft.Json;

namespace MVC_Participation2.Controllers
{
    public class LookupController : Controller
    {
        // Lookup?name=adam
        public IActionResult Index(string name = "Adam")
        {
            AgifyAPIModel agify;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync($"https://api.agify.io/?name={name}").Result;

                agify = JsonConvert.DeserializeObject<AgifyAPIModel>(json);
            }

            return View(agify);
        }
    }
}
