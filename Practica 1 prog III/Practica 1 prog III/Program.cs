using System;

namespace Practica_1_prog_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[4];
            int[] edad = new int[4];

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Escriba un nombre");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Escriba una edad");
                edad[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Menu");
            Console.WriteLine("1. Mostrar el menor");
            Console.WriteLine("2. Ordenar por nombre");
            Console.WriteLine("3. Ordenar por edad");
            int r = int.Parse(Console.ReadLine());

            if (r == 1)
            {
                //menor();
            }
            else if (r == 2)
            {

            }
            else
            {

            }

            Console.ReadKey();
        }

        public void menor(int[] edad)
        {
            int m = edad[0];

            
        }
    }
}
