using System;

namespace checherNumber.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            int fib1 = 0;
            int fib2 = 1;

            while (fib2 < num)
            {
                int fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
            }

            if (fib2 == num)
            {
                Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
            }
        }
    }
}
