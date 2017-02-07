using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  class Program
  {
    private const int NumberCalculator = 1;
    private const int DateCalculator = 2;

    static void Main(string[] args)
    {
      PrintWelcomeMessage();

      while (true)
      {
        int calculationMode = AskForCalculationMode();

        if (calculationMode == NumberCalculator)
        {
          PerformOneNumberCalculation();
        }
        else
        {
          PerformOneDateCalculation();
        }
      }
    }

    private static int AskForCalculationMode()
    {
      Console.WriteLine("Which calculator mode do you want?");
      Console.WriteLine(" {0}) Numbers", NumberCalculator);
      Console.WriteLine(" {0}) Dates", DateCalculator);
      return AskForNumber("> ");
    }

    private static void PrintWelcomeMessage()
    {
      Console.WriteLine("Welcome to the calculator!");
      Console.WriteLine("==========================");
    }

    private static void PerformOneNumberCalculation()
    {
      var op = AskForOperator();
      var numbers = AskForNumberArray(op);
      var answer = CalculateAnswer(op, numbers);

      Console.WriteLine("The answer is: {0}", answer);
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
      var count = AskForNumber(string.Format("How many numbers do you want to {0}? ", op));

      int[] numbers = new int[count];
      for (int index = 0; index < count; index++)
      {
        numbers[index] = AskForNumber(string.Format("Please enter number {0}: ", index + 1));
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
    private static void PerformOneDateCalculation()
    {
      var date = AskForDate("Please enter a date: ");
      var number = AskForNumber("Please enter the number of days to add: ");
      var answer = date.AddDays(number);

      Console.WriteLine("The answer is: {0:dd/MM/yyyy}", answer);
      Console.WriteLine();
    }

    private static DateTime AskForDate(string message)
    {
      DateTime date;

      do
      {
        Console.Write(message);
      } while (!DateTime.TryParse(Console.ReadLine(), out date));

      return date;
    }
  }
}
