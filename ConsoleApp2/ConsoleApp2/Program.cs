using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(xorSequence(2, 4));
            Console.WriteLine(xorSequence(2, 8));
            Console.WriteLine(xorSequence(5, 9));

            Console.WriteLine("-----------------");

            Console.WriteLine(xorSequence(3, 5));
            Console.WriteLine(xorSequence(4, 6));
            Console.WriteLine(xorSequence(15, 20));

            Console.ReadKey();
        }

        static int xorSequence(int l, int r)
        {
            List<int> xorArray = new List<int>() { 0 };
            int result = 0;
            for (int i = 1; i <= r; i++)
            {
                xorArray.Add(xorArray[i - 1] ^ i);
                if (i >= l)
                    result ^= xorArray[xorArray.Count-1];
            }
            return result;
        }

        //static long xorSequence(int l, int r)
        //{
        //    List<int> xorArray = BuildArray(r+1);
        //    int result = 0;
        //    for (int i = l; i <= r; i++)
        //    {
        //        result ^= xorArray[i];
        //    }
        //    return result;
        //}
    }
}
