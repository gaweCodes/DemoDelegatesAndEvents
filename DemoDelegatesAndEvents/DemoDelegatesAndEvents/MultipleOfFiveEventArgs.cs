using System;

namespace DemoDelegatesAndEvents
{
    public class MultipleOfFiveEventArgs : EventArgs
    {
        public int Total { get; set; }
        public MultipleOfFiveEventArgs(int total)
        {
            Total = total;
        }
    }
}
