using CeQueVousNeSavezPasSur.CSharp.Tasks.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeQueVousNeSavezPasSur.CSharp.Tasks.Makers
{
    /// <summary>
    /// Une chose à la fois svp.
    /// </summary>
    public class AmateurBreakfastMaker : IBreakfastMaker
    {
        public async Task<CompleteBreakfast> MakeBreakfastAsync()
        {
            var bacon = Cuisine.MakeBaconAsync().GetAwaiter().GetResult();
            var toast = Cuisine.MakeToastAsync().GetAwaiter().GetResult();
            var eggs = Cuisine.MakeEggsAsync().Result;

            return new CompleteBreakfast(bacon, toast, eggs);
        }
    }
}
