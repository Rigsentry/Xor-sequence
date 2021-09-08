using System;

namespace XOR_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            XORSequence(2, 4);
            XORSequence(2, 8);
            XORSequence(5, 9);
            
            XORSequence(3, 5);
            XORSequence(4, 6);
            XORSequence(15, 20);
        }

        public static void XORSequence(int l, int r)
        {
            int i;
            int length = r + 1;
            int[] seq = new int[length];
            seq[0] = 0;
            for(i=1;i< length; i++)
            {
                if (i % 2 == 0)
                {
                    seq[i] = seq[i - 1] + i;
                }
                else
                {
                    seq[i] = i - seq[i - 1];
                }
            }
            int sum = 0;
            for (i = l; i <= r; i++)
            {
                sum = sum ^ seq[i];
            }
            Console.WriteLine("Output : " + sum);
        }
    }
}
