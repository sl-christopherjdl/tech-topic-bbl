using CeQueVousNeSavezPasSur.CSharp.Tasks.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeQueVousNeSavezPasSur.CSharp.Tasks.Makers
{
    /// <summary>
    /// Avant, j'ai fait de la plonge. Maintenant, je cuisine pas trop mal. Pas vrai Gordon ?
    /// </summary>
    public class ComisDeCuisineBreakfastMaker : IBreakfastMaker
    {
        public async Task<CompleteBreakfast> MakeBreakfastAsync()
        {
            var bacon = await Cuisine.MakeBaconAsync();
            var toast = await Cuisine.MakeToastAsync();
            var eggs = await Cuisine.MakeEggsAsync();

            return new CompleteBreakfast(bacon, toast, eggs);
        }
    }
}
