namespace Problems
{
    public class Problem006
    {
        // https://projecteuler.net/problem=6
        // Returns (1 + 2 + ... + n)^2 - (1^2 + 2^2 + ... + n^2).
        public static uint run(uint n=100)
        {
            /* https://www.planetmath.org/SquareOfSum
             * (\sum a_i)^2 - \sum a_i^2 
             * = \sum a_i^2 + 2 \sum_{i < j} a_i a_j - \sum a_i^2
             * = 2 \sum_{i < j} a_i a_j
             */
            uint sum = 0;

            for (uint i = 1; i <= n; i++)
                for (uint j = 1; j < i; j++)
                    sum += i * j;
            return sum * 2;
        }
    }
}