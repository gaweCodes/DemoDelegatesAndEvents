using System;

namespace DemoDelegatesAndEvents
{
    internal class Program
    {
        private static void Main()
        {
            var adder = new Adder();
            adder.OnMultipleOfFiveReached += MultipleOfFiveReached;

            var answer = adder.Add(4, 3);
            Console.WriteLine($"answer={answer}");
            answer = adder.Add(4, 6);
            Console.WriteLine($"answer={answer}");
            Console.Read();
        }

        private static void MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e)
        {
            Console.WriteLine($"Multiple of five reached: {e.Total}!");
        }
    }
}
