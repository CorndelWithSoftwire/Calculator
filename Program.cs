using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintWelcomeMessage();

      while (true)
      {
        PerformOneCalculation();
      }
    }

    private static void PrintWelcomeMessage()
    {
      Console.WriteLine("Welcome to the calculator!");
      Console.WriteLine("==========================");
    }

    private static void PerformOneCalculation()
    {
      var op = AskForOperator();
      var numbers = AskForNumberArray(op);
      var answer = CalculateAnswer(op, numbers);

      Console.WriteLine("The answer is: " + answer);
      Console.WriteLine();
    }

    private static string AskForOperator()
    {
      Console.Write("Please enter the operator: ");
      string op = Console.ReadLine();
      return op;
    }

    private static int[] AskForNumberArray(string op)
    {
      var count = AskForNumber("How many numbers do you want to " + op + "? ");

      int[] numbers = new int[count];
      for (int index = 0; index < count; index++)
      {
        numbers[index] = AskForNumber("Please enter number " + (index + 1) + ": ");
      }
      return numbers;
    }

    private static int AskForNumber(string message)
    {
      int count;

      do
      {
        Console.Write(message);
      } while (!int.TryParse(Console.ReadLine(), out count));

      return count;
    }

    private static int CalculateAnswer(string op, int[] numbers)
    {
      int answer = numbers[0];

      for (int index = 1; index < numbers.Length; index++)
      {
        if (op == "*")
        {
          answer = answer*numbers[index];
        }
        else if (op == "/")
        {
          answer = answer/numbers[index];
        }
        else if (op == "+")
        {
          answer = answer + numbers[index];
        }
        else if (op == "-")
        {
          answer = answer - numbers[index];
        }
      }
      return answer;
    }
  }
}
