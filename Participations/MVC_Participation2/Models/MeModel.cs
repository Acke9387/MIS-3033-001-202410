namespace MVC_Participation2.Models
{
    public class MeModel
    {

        public string Name { get; set; }
        public string Definition { get; set; }

        public string Pronunciation { get; set; }

        public string Info { get;set; }


        public MeModel()
        {
            Name = string.Empty;
            Definition = string.Empty;
            Pronunciation = string.Empty;
            Info = string.Empty;
        }

    }
}
