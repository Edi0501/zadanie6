using System;
using System.Dynamic;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj trzy rózne liczby");
            Console.WriteLine("Podaj pierwszą liczbę:");
            int a =25;
            int b = 63;
            int c = 79;
            
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Podaj drugą liczbę");
            Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Podaj trzecią liczbę");
            Int32.TryParse(Console.ReadLine(), out c);
            if (a > b && a > c)
            {
                Console.WriteLine("Pierwsza liczba jest największa");
            }
            else if (b > a && b > c) 
            {
                Console.WriteLine("Druga liczba jest największa");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Trzecia  liczba jest największa");
            }
            else if ( a == b && a == c)
            {
                Console.WriteLine("Liczby maja ta samą wartość");
            }
            else
            {
                Console.WriteLine("Podałeś złe liczby");
            }
            
        }
    }
}