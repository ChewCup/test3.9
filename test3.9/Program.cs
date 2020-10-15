using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] stat = new int[7];
            for(int i = 0; i < 7; i++)
            {
                stat[i] = 0;
            }
            for(int i = 0; i <= 100; i++)
            {
                int r = rand.Next(1, 7);
                stat[r] = stat[r] + 1;
                Console.Write("{0}, ", r);
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("{0}: {1}", i, stat[i]);
            }


            Console.ReadKey();
        }
    }
}
