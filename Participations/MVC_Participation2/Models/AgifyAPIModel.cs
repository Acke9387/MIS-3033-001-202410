namespace MVC_Participation2.Models
{
    public class AgifyAPIModel
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int Age { get; set; }

        public AgifyAPIModel()
        {
            Name = string.Empty;
            Count = -1;
            Age = -1;
        }
    }
}
