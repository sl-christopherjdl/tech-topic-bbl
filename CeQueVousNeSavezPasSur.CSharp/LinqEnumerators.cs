using CeQueVousNeSavezPasSur.CSharp.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CeQueVousNeSavezPasSur.CSharp
{
    public class LinqEnumerators
    {
        readonly IAnnoncesReader reader = new AnnoncesReader();

        public void RunExample()
        {
            var annonces = reader.GetAnnoncesFromDatabaseWhereIdAgenceIsNotNull();

            Treatment1(annonces);
            Treatment2(annonces);
        }

        public void Treatment1(IReadOnlyCollection<Annonce> annonces) => annonces.Select(Treat);

        private Annonce Treat(Annonce annonce)
        {
            if (annonce.Adresse.Contains("apéro"))
            {
                Console.WriteLine("apéro!");
            }
            return annonce;
        }

        public void Treatment2(IReadOnlyCollection<Annonce> annonces)
        {
            foreach (var annonce in annonces)
            {
                if (annonce.Adresse.Contains("Ajaccio"))
                {
                    Console.WriteLine("apéro sous le soleil.");
                }
            }
        }
    }
}
