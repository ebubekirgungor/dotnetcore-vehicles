namespace WebApplication1
{
    public abstract class vehicle
    {
        public string color { get; set; }
        public int id { get; set; }
    }
    public class color
    {
        public const string red = "red";
        public const string blue = "blue";
        public const string black = "black";
        public const string white = "white";
    }

    public class car : vehicle
    {
        public int wheels { get; set; }
        public bool headlights { get; set; }
    }

    public class boat : vehicle
    {
    }

    public class bus : vehicle
    {
    }
}
