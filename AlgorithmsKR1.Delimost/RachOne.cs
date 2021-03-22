using System;

namespace AlgorithmsKR1.Delimost
{
    public class RachOne : DivisibilityBase
    {
        public override void Compute(int maxIterCount)
        {
            int a, b;
            int m, k;

            a = SplitNumber(P, out b);

            var curN = N;
            var iterCount = 0;
            
            Console.WriteLine($"a = {a}, b = {b}");
            while (curN > P && iterCount < maxIterCount)
            {
                m = SplitNumber(curN, out k);
                curN = m * b - k * a;
                
                Console.WriteLine($"Offset: {Offset} | m = {m}, k = {k} | CurN = {curN}");

                iterCount++;
            }
        }
    }
}