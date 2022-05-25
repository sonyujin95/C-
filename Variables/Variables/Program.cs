using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string name = "손유진";
            char exmark = '!';
            //sbyte age;
            //age = 26;
            sbyte age = 26;  // 두 가지 방식 가능

            Console.WriteLine("Hello " + name + exmark);
            Console.Write("You are " + age + " years old" + exmark);
        }
    }
}