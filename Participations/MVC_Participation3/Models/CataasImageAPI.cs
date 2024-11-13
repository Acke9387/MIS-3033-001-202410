namespace MVC_Participation3.Models
{
    public class CataasImageAPI
    {
        public string _Id { get; set; }

        public List<string> Tags { get;set; }

        public CataasImageAPI()
        {
            _Id = string.Empty;
            Tags = new List<string>();
        }

        public string GenerateImageURL()
        {
            string url = $"https://cataas.com/cat/{_Id}";
            return url;
        }
    }
}
