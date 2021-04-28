using CeQueVousNeSavezPasSur.CSharp.Tasks.Ingredients;
using CeQueVousNeSavezPasSur.CSharp.Tasks.Makers;
using CeQueVousNeSavezPasSur.CSharp.Tasks.Makers.Pro;
using CeQueVousNeSavezPasSur.CSharp.Tasks.Makers.Pro.Patissier;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CeQueVousNeSavezPasSur.CSharp.Tasks
{
    public class Restaurant
    {
        readonly private static IBreakfastMaker cooker = new CyrilLignacBreakfastMaker();

        public static async Task Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            CompleteBreakfast completeBreakfast = await cooker.MakeBreakfastAsync();
            sw.Stop();
            ExaminateBreakfast(completeBreakfast, sw.Elapsed.Seconds);
        }

        public static void ExaminateBreakfast(CompleteBreakfast completeBreakfast, int secondsElapsed)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"You took {secondsElapsed} seconds to make food.");
            Console.WriteLine("Let's take a look at this breakfast:");
            Console.WriteLine(completeBreakfast.Bacon);
            Console.WriteLine(completeBreakfast.Toast);
            foreach (var egg in completeBreakfast.Eggs)
                Console.WriteLine(egg);
        }
    }
}
