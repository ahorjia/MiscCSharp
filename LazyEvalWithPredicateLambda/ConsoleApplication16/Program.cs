using System;
using System.Collections.Generic;

namespace ConsoleApplication16
{
    delegate bool MyD(int i);

    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();
            var retVals = p.GetVals(5);

            foreach (var int1 in retVals)
            {
                Console.WriteLine(int1);

                if (int1 == 8)
                    break;
            }

            Console.WriteLine("done");
        }

        private Random rnd = new Random();

        MyD d;

        private IEnumerable<int> GetVals(int max)
        {
            d = (x) => { if (max == -1) return true; else return x != max; };

            int counter = 0;

            while (d(counter++))
            {
                yield return rnd.Next(0, 10);
            }
        }
    }
}