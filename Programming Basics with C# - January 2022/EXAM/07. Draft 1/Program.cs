using System;

namespace _6ta
{
    class Program
    {
        static void Main(string[] args)
        {
            //•   K – цяло число в интервала[0..8]
            int k = int.Parse(Console.ReadLine());
            //•   L – цяло число в интервала[0..9]
            int l = int.Parse(Console.ReadLine());
            //•   M– цяло число в интервала[0..8]
            int m = int.Parse(Console.ReadLine());
            //•   N – цяло число в интервала[0..9]
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            for (int i = k; i <= 8; i++)
            {
                if (br == 6)
                {
                    break;
                }
                if (i % 2 != 0)
                {
                    continue;
                }
                for (int o = 9; o >= l; o--)
                {
                    if (br == 6)
                    {
                        break;
                    }
                    if (o % 2 == 0)
                    {
                        continue;
                    }
                    for (int y = m; y <= 8; y++)
                    {
                        if (br == 6)
                        {
                            break;
                        }
                        if (y % 2 != 0)
                        {
                            continue;
                        }
                        for (int q = 9; q >= n; q--)
                        {
                            if (q % 2 == 0)
                            {
                                continue;
                            }
                            if (i * 10 + o == y * 10 + q)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else
                            {
                                Console.WriteLine($"{i * 10 + o} - {y * 10 + q}");
                                br++;
                                if (br == 6)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
