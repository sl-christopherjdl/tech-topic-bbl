using CeQueVousNeSavezPasSur.CSharp.Tasks.Ingredients;
using System.Threading.Tasks;

namespace CeQueVousNeSavezPasSur.CSharp.Tasks.Makers.Pro
{
    /// <summary>
    /// "M'en voulez pas, mais je vais aller manger ailleurs."
    /// Philippe
    /// </summary>
    class PhilippeEtchebestBreakfastMaker : IBreakfastMaker
    {
        public async Task<CompleteBreakfast> MakeBreakfastAsync()
        {
            var baconTask = Cuisine.MakeBaconAsync();
            var toastTask = Cuisine.MakeToastAsync();
            var eggsTask = Cuisine.MakeEggsAsync();

            var bacon = await baconTask;
            var toast = await toastTask;
            var eggs = await eggsTask;

            return new(bacon, toast, eggs);
        }
    }
}
