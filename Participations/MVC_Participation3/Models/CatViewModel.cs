namespace MVC_Participation3.Models
{
    public class CatViewModel
    {
        public string ImageUrl { get; set; }
        public string Fact { get; set; }

        public CatViewModel()
        {
            ImageUrl = string.Empty;
            Fact = string.Empty;
        }
    }
}
