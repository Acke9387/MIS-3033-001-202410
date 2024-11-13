using Microsoft.AspNetCore.Mvc;
using MVC_Participation3.Models;

namespace MVC_Participation3.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Cat()
        {
            HistoryCatModel hcm = new HistoryCatModel()
            {
                AncientEgypt = "Egyptians highly valued cats, considering them sacred and often mummifying them after death. This is where the association between cats and worship became most prominent. \r\n",
                Domestication = "The earliest evidence of cat domestication comes from the Middle East, where wildcats likely began to live near human settlements to prey on rodents attracted to grain stores. \r\n",
                Evolution = "Cats have changed physically over thousands of years of living with humans, including:\r\nSmaller overall size \r\n \r\nSlightly smaller brain \r\n \r\nMore colorful coats \r\n \r\nVertically slit rather than rounded pupils \r\n \r\nEvolved to communicate with humans using shorter, higher-pitched meows",
                HousePets = "It was long thought that the domestication of the cat began in ancient Egypt, where cats were venerated from around 3100 BC. However, the earliest known indication for the taming of an African wildcat was excavated close by a human Neolithic grave in Shillourokambos, southern Cyprus, dating to about 7500–7200 BC.",
                SpreadAmericas = "Cats arrived in the Americas with European settlers. Cats were useful on ships, protecting stores from rats and other vermin.",
                SpreadEurope = "Cats spread to Europe from Anatolia, which is now Turkey, as early as 4,400 B.C.E. The Vikings also helped spread cats across Europe by taking them on their voyages.",
            };


            return View(hcm);
        }
    }
}
