using CeQueVousNeSavezPasSur.CSharp.Tasks.Ingredients;
using System.Threading.Tasks;

namespace CeQueVousNeSavezPasSur.CSharp.Tasks
{
    public interface IBreakfastMaker
    {
        public Task<CompleteBreakfast> MakeBreakfastAsync();
    }
}