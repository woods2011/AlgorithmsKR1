using System;

namespace AlgorithmsKR1.Delimost
{
    public interface IDivisibility
    {
        public int N { get; init; }
        public int P { get; init; }

        public int Offset { get; init; }

        public void Compute(int maxIterCount);
    }

    public abstract class DivisibilityBase : IDivisibility
    {
        public int N { get; init; }
        public int P { get; init; }
        public int Offset { get; init; }

        public abstract void Compute(int maxIterCount);

        protected int SplitNumber(int x, out int rem)
        {
            return Math.DivRem(x, (int)Math.Pow(10, Offset), out rem);
        }
    }
}