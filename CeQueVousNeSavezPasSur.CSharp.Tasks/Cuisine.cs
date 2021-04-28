using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CeQueVousNeSavezPasSur.CSharp.Tasks.Ingredients;

namespace CeQueVousNeSavezPasSur.CSharp.Tasks
{
    /// <summary>
    /// Aussi appelée Kouizine.
    /// </summary>
    public static class Cuisine
    {
        public static async Task<Bacon> MakeBaconAsync()
        {
            Console.WriteLine("I am making the bacon");
            await Task.Delay(5000);
            Console.WriteLine("I made the bacon");
            return new();
        }

        public static async Task<Toast> MakeToastAsync()
        {
            Console.WriteLine("I am toasting the toast");
            await Task.Delay(2000);
            Console.WriteLine("Toast is toasted.");
            return new();
        }

        public static async Task<IEnumerable<Egg>> MakeEggsAsync()
        {
            Console.WriteLine("I am cooking the eggs");
            await Task.Delay(5000);
            Console.WriteLine("I made scrambled eggs.");
            return new Egg[] { new(), new() };
        }
    }
}
