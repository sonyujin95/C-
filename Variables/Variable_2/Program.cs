using System;

namespace Variable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double A = 10.5;

            // placeholder 방식이 아닌 interpolation 방식을 사용하고 있다.
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"A = {A}");

            Console.ReadKey();
        }
    }
}
