namespace rekursii_3
{
    using System;

    class Program
    {
        static int ReverseNumber(int n, int reversed = 0)
        {         
            if (n == 0)
            {
                return reversed;
            }         
            return ReverseNumber(n/10, reversed * 10 + n% 10);
        }

        static void Main(string[] args)
        {             
            Console.WriteLine("Vyvedete chislo: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = ReverseNumber(number);
            Console.WriteLine ($"Obyrnatoto chislo e: {reversedNumber}");
        }
    }
}
