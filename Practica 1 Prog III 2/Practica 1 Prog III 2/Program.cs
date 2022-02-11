using System;

namespace Practica_1_Prog_III_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = 10;
            int[] v = new int[10];

            Console.WriteLine("Vector");

            for (int k = n - 1; k >= 0; k--)
            {
                v[k] = r.Next(0, 11);
                Console.Write(v[k] + " ");
            }

            Console.WriteLine("Vector ordenado");
            
            int c;

            for (int i = n - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (v[j] > v[j + 1])
                    {
                        c = v[j + 1];
                        v[j + 1] = v[j];
                        v[j] = c;
                    }

            for (int k = n - 1; k >= 0; k--)
            {
                Console.Write(v[k] + " ");
            }

            Console.ReadKey();
        }
    }
}
