using System;

namespace day4_2
{
    class Program{
        static void Main(string[] args)
        {
            // 배열을 foreach 를 사용하여 출력
            string[] s = { "Jim", "Sam", "Kim", "Park"};

            foreach (string x in s)
            {
                Console.WriteLine(x);
            }

            // while문으로 1부터 100까지 합계 구하기
            int sum = 0;
            int i = 1;

            while (i <= 100)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);

            // do..while 을 사용한 반복문
            // 아래는 while 문이 거짓이 되지만
            // Hello를 한번은 출력함
            int j = 0;
            do
            {
                Console.WriteLine("Hello");
                j++;
            } while (j<0);
        }
    }
}