using System;
namespace test
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Skriv en tal som är störa än 5");
            int x = int.Parse(Console.ReadLine());

            if (x < 5)
                Console.WriteLine("Det är fel");
            else
                Console.WriteLine("Det är rätt");
        }
    }

} 