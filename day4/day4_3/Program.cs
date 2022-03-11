using System;

namespace day4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 0;

            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}