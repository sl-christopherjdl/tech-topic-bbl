using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CeQueVousNeSavezPasSur.CSharp.Data
{
    public class AnnoncesReader : IAnnoncesReader
    {
        public IReadOnlyCollection<Annonce> GetAnnoncesFromDatabaseWhereIdAgenceIsNotNull()
        {
            return AllAnnonces.Where(a => a.IdAgence is not null).ToList(); // C#9 pattern matching
        }

        private static Annonce[] AllAnnonces =
        {
            new ()
            {
                Id = Guid.NewGuid(),
                Adresse = "44 rue de la Mafia Ajaccio",
                IdAgence = 15
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Adresse = "98 rue de Napoléon, Ajaccio",
                IdAgence = null
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Adresse = "44 avenue de l'apéro, Kuranda City",
                IdAgence = 38
            }
        };


        private int GetIdAgenceOrDefault(Annonce annonce)
        {
            const int defaultId = 999;
            return annonce.IdAgence ?? defaultId;
        }
    }

    public interface IAnnoncesReader
    {
        IReadOnlyCollection<Annonce> GetAnnoncesFromDatabaseWhereIdAgenceIsNotNull();
    }
}
