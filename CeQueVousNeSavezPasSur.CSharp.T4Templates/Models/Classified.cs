
namespace CeQueVousNeSavezPasSur.CSharp.T4Templates
{
    public class Classified
    {
        public string Id { get; set; }
        public int NumberOfParkings { get; set; }
        public Shop Shop { get; set; }
    }

    public class Shop
    {
        public int NumberOfRooms { get; set; }
    }
}