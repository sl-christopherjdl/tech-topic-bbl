
namespace CeQueVousNeSavezPasSur.CSharp.T4Templates
{
    public class PolirisClassified
    {
        public string RoomsNb { get; set; }
        public string Identifier { get; set; }
        public string Parkings_Nb { get; set; }

        public override string ToString()
        {
            return $@"{nameof(RoomsNb)}:{RoomsNb}
{nameof(Identifier)}:{Identifier}
{nameof(Parkings_Nb)}:{Parkings_Nb}";
        }
    }
}