using System;

namespace lab4ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati - o si afisati-i rezultatul.
            Console.WriteLine("Introduceti n ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine( GrandSum(n));

        }
        static int GrandSum(int n)
        {
            if (n == 0)
            {
                return n;
            }
            return n + GrandSum(n - 1);
        }
    }
}
