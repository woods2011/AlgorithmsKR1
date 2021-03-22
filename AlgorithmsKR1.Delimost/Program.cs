using System;

namespace AlgorithmsKR1.Delimost
{
    class Program
    {
        static void Main(string[] args)
        {
            IDivisibility iDiv = new RachThree() {N = 4088, P = 73, Offset = 1};
            
            iDiv.Compute(10);
        }
    }
}