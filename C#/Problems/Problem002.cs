namespace Problems
{
    public class Problem002
    {
        // https://projecteuler.net/problem=2
        // Returns the sum of even Fibbonacci term below maxValue.
        public static uint run(uint maxValue=4000000)
        {
            uint a = 1, b = 2;

            // 2 is even number
            uint evenSum = 2;

            uint tmp;
            while (b < maxValue)
            {
                tmp = a;
                a = b;
                b = b + tmp;

                if (b % 2 == 0)
                    evenSum += b;
            }
            return evenSum;
        }
    }
}