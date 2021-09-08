using System;
using System.Collections.Generic;

namespace Xor_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = 3;
            var input1 = new int[][]
            {
                new int[]{ 2, 4 },
                new int[]{ 2, 8 },
                new int[]{ 5, 9 },
            };

            var n2 = 3;
            var input2 = new int[][]
            {
                new int[]{ 3, 5 },
                new int[]{ 4, 6 },
                new int[]{ 15, 20 },
            };

            findResult(n1, input1);

            Console.WriteLine("-----------------");

            findResult(n2, input2);
        }

        static void findResult(int n, int[][] input)
        {
            var greater = findHigherIndex(n, input);

            var xorArray = generateXorArray(greater);

            for (var i = 0; i < n; i++)
            {
                var result = 0;
                int star = input[i][0];
                int end = input[i][1];
                for (var j = star; j <= end; j++)
                {
                    result = result ^ xorArray[j];
                }
                Console.WriteLine(result);
            }
        }

        static int findHigherIndex(int n, int[][] input)
        {
            var greater = 0;

            for (var i = 0; i < n; i++)
            {
                if (greater < input[i][1])
                {
                    greater = input[i][1];
                }
            }

            return greater;
        }

        static List<int> generateXorArray(int greater)
        {
            var xorArray = new List<int>();
            var xorValue = 0;
            
            for (var i = 0; i <= greater; i++)
            {
                if (i == 0)
                {
                    xorArray.Add(i);
                }
                else
                {
                    xorValue = xorArray[i - 1] ^ i;
                    xorArray.Add(xorValue);
                }
            }

            return xorArray;
        }        
    }
}
