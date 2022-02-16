// C# 1일차
using System;

namespace Day1
{
  class Program
  {
    static void Main(string[] args)
    {
      for (;;)
      {
        Console.Write("점수를 입력하세요: ");
        string answer = Console.ReadLine();

        if (answer == "")
        {
          break;
        }

        int score = int.Parse(answer);

        if (score >= 101)
        {
          Console.WriteLine("잘못된 점수입니다. 다시 입력해주세요.");
        }
        else if (score >= 90)
        {
          Console.WriteLine("A등급");
        }
        else if (score >= 80)
        {
          Console.WriteLine("B등급");
        }
        else if (score >= 70)
        {
          Console.WriteLine("C등급");
        }
        else if (score >= 60)
        {
          Console.WriteLine("D등급");
        }
        else if (score < 0)
        {
          Console.WriteLine("음수는 입력할 수 없습니다. 다시 입력해주세요.");
        }
        else
        {
          Console.WriteLine("F등급");
        }
      }
    }
  }
}