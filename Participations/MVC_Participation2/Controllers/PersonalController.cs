using Microsoft.AspNetCore.Mvc;
using MVC_Participation2.Models;

namespace MVC_Participation2.Controllers
{
    public class PersonalController : Controller
    {
        // this route would be Personal/Me because of the controller and the method/action name
        public IActionResult Me() // this is called an action, but it really is just a method
        {
            MeModel me = new MeModel();
            me.Name = "Adam";
            me.Definition = "The name Adam is usually given to a Boy. And we are pleased to let you know that we found the meaning of your name, Man, Of The Earth. The origin of the name lies in Hebrew.";
            me.Pronunciation = "A-dam";
            me.Info = "Adam originates in Hebrew language and means \"man\". In the Bible, Adam is a figure from the Book of Genesis and supposedly the first human God created from the earth. He lived with Eve in the Garden of Eden until he ate a forbidden fruit and was expelled. In the US the popularity of Adam started growing in the 1960s and currently it is a very popular masculine given name not only in the English-speaking world, but in other languages as well.";

            return View(me);
        }
    }
}
