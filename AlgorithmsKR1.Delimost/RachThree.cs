using System;

namespace AlgorithmsKR1.Delimost
{
    public class RachThree : DivisibilityBase
    {
        public override void Compute(int maxIterCount)
        {
            int a, b, bb, q, qq;
            int m, k;

            a = SplitNumber(P, out b);
            switch (b)
            {
                case 3: case 7: bb = b; 
                    break;
                case 1: case 9: bb = 10 - b; 
                    break;
                default: throw new ArgumentException("b не подходит, ежи");
            }
            
            q = (P * bb + 1) / 10;
            qq = Math.Abs(P - q);

            var curN = N;
            var iterCount = 0;
            
            
            Console.WriteLine($"a = {a}, b = {b}, b* = {bb}, q = {q}, q* = {qq}");
            while (curN > P && iterCount < maxIterCount)
            {
                m = SplitNumber(curN, out k);
                curN = m - k * qq;
                
                Console.WriteLine($"Offset: {Offset} | m = {m}, k = {k} | CurN = {curN}");

                iterCount++;
            }
        }
    }
}