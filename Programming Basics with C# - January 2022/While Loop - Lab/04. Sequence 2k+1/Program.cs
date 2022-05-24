using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Read number "n"
            int n = int.Parse(Console.ReadLine());
            int m = 1;
            //2. console writes numbes <= n; numbers 1, 3, ... n * 2 +1;

            while (m<=n)
            {
                Console.WriteLine(m);
                m = m * 2 + 1;
            }
        }
    }
}
