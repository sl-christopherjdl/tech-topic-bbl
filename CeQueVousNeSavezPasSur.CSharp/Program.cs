using CeQueVousNeSavezPasSur.CSharp.Data;
using System;

namespace CeQueVousNeSavezPasSur.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int, int> tuple = Tuple.Create(1, 2, 3);

            tuple.Item1.ToString();

            (int id, int nombreDeZouzes, string nomDuMec) bob = ValueTuple.Create(1, 2, "Loic");

            ///

            Annonce annonce = new()
            {
                Id = Guid.NewGuid(),
                Adresse = "44 rue de la Mafia Ajaccio",
                IdAgence = 15
            };

            (string addresse, _, int? t) = annonce;

            var (id1, id2, id3) = tuple;
        }
    }
}
