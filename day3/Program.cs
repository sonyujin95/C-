using System;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 결합 (string concatenation)
            string s1 = "Hello";
            string s2 = "World";

            string s = s1 + " " + s2;
            Console.WriteLine(s);    // "Hello World"

            // 부분 문자열 (substring)
            string sub = s.Substring(1, 4);
            Console.WriteLine(sub);  // "ello"

            // 문자열에서 공백으로 분리
            s = "I am a boy";
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            // 문자열에서 한 문자
                s = "Hello";
                char c = s[0];  // H
                c = s[1];       // e
                c = s[2];       // l
                Console.WriteLine(c);
        }
    }
}