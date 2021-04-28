using CeQueVousNeSavezPasSur.CSharp.Tasks.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeQueVousNeSavezPasSur.CSharp.Tasks.Makers.Pro.Patissier
{
    /// <summary>
    /// Une petite purée de carottes... pourquoi les enfants n'en mangent pas ?
    /// </summary>
    public class CyrilLignacBreakfastMaker : IBreakfastMaker
    {
        public async Task<CompleteBreakfast> MakeBreakfastAsync()
        {
            var baconTask = Cuisine.MakeBaconAsync();
            var toastTask = Cuisine.MakeToastAsync();
            var eggsTask = Cuisine.MakeEggsAsync();

            await Task.WhenAll(baconTask, toastTask, eggsTask);
            return new CompleteBreakfast(baconTask.Result, toastTask.Result, eggsTask.Result);
        }
    }
}
