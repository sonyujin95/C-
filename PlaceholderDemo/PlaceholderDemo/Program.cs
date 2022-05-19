using System;

namespace PlaceholderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            double y = 3.14;
            char z = 'A';

            // x, y, z 값을 출력한다.
            Console.WriteLine("{0}, {1}, {2}", x, y, z);

            // x, x, x 값을 출력한다.
            Console.WriteLine("{0}, {0}, {0}", x, y, z);

            // y, y, y 값을 출력한다.
            Console.WriteLine("{1}, {1}, {1}", x, y, z);

            // z, z, z 값을 출력한다.
            Console.WriteLine("{2}, {2}, {2}", x, y, z);

            // z, y, x 값을 출력한다.
            Console.WriteLine("{2}, {1}, {0}", x, y, z);
        }
    }
}
