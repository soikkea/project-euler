using System;

namespace Problems
{
    public class Problem001
    {
        // https://projecteuler.net/problem=1
        // Returns the sum of all the multiples of 3 or 5 below n.
        public static uint run(uint n=1000u)
        {
            uint sum = 0;

            for (uint i = n - 1; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}
