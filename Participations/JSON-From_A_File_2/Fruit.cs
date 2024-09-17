namespace JSON_From_A_File_2
{
    public class Fruit
    {

        public string name { get; set; }
        public string image { get; set; }

        public double price { get; set; }

        public Fruit()
        {
            name = "";
            image = "";
            price = 0.0;
        }

        public override string ToString()
        {
            return name;
        }
    }
}