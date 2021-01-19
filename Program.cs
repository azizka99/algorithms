using System;

namespace vahav4
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(chislo % 10 * 100 + chislo / 10);

        
        }
    }
}
