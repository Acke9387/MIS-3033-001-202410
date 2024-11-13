namespace MVC_Participation3.Models
{
    public class HistoryCatModel
    {

        public string Evolution { get; set; }
        public string Domestication { get; set; }
        public string AncientEgypt { get; set; }
        public string SpreadEurope { get; set; }
        public string SpreadAmericas { get; set; }
        public string HousePets { get; set; }

        public HistoryCatModel()
        {
            Evolution = string.Empty;
            Domestication = string.Empty;
            AncientEgypt = string.Empty;
            SpreadEurope = string.Empty;
            SpreadAmericas = string.Empty;
            HousePets = string.Empty;
        }


    }
}
