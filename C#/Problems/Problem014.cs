using System.Collections.Generic;

namespace Problems
{
    public class Problem014
    {
        // https://projecteuler.net/problem=14
        // Returns the number < n that starts the longest Collatz sequence.
        public static uint run(uint n=1000000)
        {
            uint maxLength = 1;
            uint maxIndex = 1;

            // Stores the length of the Collatz sequence with the key integer.
            Dictionary<uint, uint> lengths = new Dictionary<uint, uint>();
            // Stores the numbers in the sequence
            List<uint> sequence = new List<uint>();

            uint length = 0;
            uint collatz = 0;
            lengths.Add(1u, 1u);

            for (uint i = 2; i < n; i++)
            {
                sequence.Clear();
                length = 0;
                collatz = i;
                while (true)
                {
                    if (lengths.TryGetValue(collatz, out uint tryLength))
                    {
                        length += tryLength;
                        break;
                    }
                    else 
                    {
                        length++;
                        sequence.Add(collatz);
                    }
                    if (collatz % 2 == 0)
                        collatz = collatz / 2;
                    else
                        collatz = 3 * collatz + 1;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    maxIndex = i;
                }
                foreach (uint j in sequence)
                {
                    lengths.Add(j, length--);
                }
            }
            return maxIndex;
        }
    }
}