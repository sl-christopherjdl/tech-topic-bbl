using System;

namespace CeQueVousNeSavezPasSur.CSharp.T4Templates
{
    class Program
    {
        static void Main(string[] args)
        {
            var classified = new Classified()
            {
                Id = Guid.NewGuid().ToString(),
                NumberOfParkings = 12,
                Shop = new Shop { NumberOfRooms = 42 }
            };

            PolirisClassified polirisClassified = BasicPolirisMapper.Map(classified);

            Console.WriteLine(polirisClassified);
        }
    }
}
