using System;

namespace DemoDelegatesAndEvents
{
    public class Adder
    {
        public int Add(int x, int y)
        {
            var sum = x + y;
            if (sum % 5 == 0)
                OnMultipleOfFiveReached?.Invoke(this, new MultipleOfFiveEventArgs(sum));
            return sum;
        }
        public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;
    }
}
