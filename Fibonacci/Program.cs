using System;

namespace Fibonacci
{
    class Program
    {
        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" fib of given number is :" + Fib(n));
        }
    }
}
