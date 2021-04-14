using System;

namespace CeQueVousNeSavezPasSur.CSharp.Data
{
    public class Annonce
    {
        public Annonce()
        {

        }
        public string Adresse { get; set; }
        public Guid Id { get; set; }
        public int? IdAgence { get; set; }

        public void Deconstruct(out string adresse, out Guid id, out int? idAgence)
        {
            adresse = Adresse;
            id = Id;
            idAgence = IdAgence;
        }
    }
}
