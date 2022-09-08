namespace WebAppDETAug2022.Modelss
{
    public class Ticket
    {
        public string Category { get; set; }
        public int Price { get; set; }
        public int MaxLimit { get; set; }
        public int ID { get; internal set; }
    }
}
