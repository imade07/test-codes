using System;

namespace Binary
{
    class Kata
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(1234));
        }

        static int CountBits(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    }
}