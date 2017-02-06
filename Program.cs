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
      Console.WriteLine("Welcome to the calculator!");
      Console.WriteLine("==========================");

      Console.Write("Please enter the operator: ");
      string op = Console.ReadLine();

      Console.Write("How many numbers do you want to " + op + "? ");
      int count = int.Parse(Console.ReadLine());

      int[] numbers = new int[count];
      for (int index = 0; index < count; index++)
      {
        Console.Write("Please enter number " + (index + 1) + ": ");
        numbers[index] = int.Parse(Console.ReadLine());
      }

      int answer = numbers[0];

      for (int index = 1; index < count; index++)
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

      Console.WriteLine("The answer is: " + answer);

      Console.ReadLine();
    }
  }
}
