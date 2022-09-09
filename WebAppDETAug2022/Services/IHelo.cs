namespace WebAppDETAug2022.Services
{
    public interface IHelo
    {
        string SayHelo(string name);
    }
    public class Helo1 : IHelo
    {
        public string SayHelo(String name)
        {
            return $"Helo {name} , Welocme to ASP.NET Core";
        }
    }
    public class Helo2 : IHelo
    {
        public string SayHelo(string name)
        {
            return $"hai , Helo {name}, What are you doing here?";
        }
    }
}
