using Microsoft.AspNetCore.Mvc;
using MVC_Participation3.Models;
using Newtonsoft.Json;

namespace MVC_Participation3.Controllers
{
    public class CatController : Controller
    {
        public IActionResult Index(int number = 5)
        {
            List<FactAPI> facts = new List<FactAPI>();

            for (int i = 0; i < number; i++)
            {
                FactAPI fact;
                using (var client = new HttpClient())
                {
                    var json = client.GetStringAsync("https://catfact.ninja/fact").Result;
                    fact = JsonConvert.DeserializeObject<FactAPI>(json);

                    facts.Add(fact);
                }
            }

            List<CataasImageAPI> images;
            using (var client = new HttpClient())
            {
                string url = $"https://cataas.com/api/cats?skip=0&limit={number}";
                var json = client.GetStringAsync(url).Result;
                images = JsonConvert.DeserializeObject<List<CataasImageAPI>>(json);
            }
            List<CatViewModel> cats = new List<CatViewModel>();
            for (int i = 0; i < number; i++)
            {
                var cat = new CatViewModel();
                cat.Fact = facts[i].fact;
                cat.ImageUrl = images[i].GenerateImageURL();
                cats.Add(cat);
            }

            return View(cats);
        }

        public IActionResult Facts(int number = 5)
        {
            List<FactAPI> facts = new List<FactAPI>();

            for (int i = 0; i < number; i++)
            {
                FactAPI fact;
                using (var client = new HttpClient())
                {
                    var json = client.GetStringAsync("https://catfact.ninja/fact").Result;
                    fact = JsonConvert.DeserializeObject<FactAPI>(json);

                    facts.Add(fact);
                }

            }

            return View(facts);
        }

        public IActionResult Image(int number = 5)
        {
            List<CataasImageAPI> images;
            using (var client = new HttpClient())
            {
                string url = $"https://cataas.com/api/cats?skip=0&limit={number}";
                var json = client.GetStringAsync(url).Result;
                images = JsonConvert.DeserializeObject<List<CataasImageAPI>>(json);
            }

            return View(images);
        }

    }
}
