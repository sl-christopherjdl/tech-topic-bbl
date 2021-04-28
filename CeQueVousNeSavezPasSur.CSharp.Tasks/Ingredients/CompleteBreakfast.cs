namespace CeQueVousNeSavezPasSur.CSharp.Tasks.Ingredients
{
    using System.Collections.Generic;

    public record CompleteBreakfast(Bacon Bacon, Toast Toast, IEnumerable<Egg> Eggs);
}
