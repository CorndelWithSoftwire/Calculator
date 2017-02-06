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

      Console.Write("Please enter the first number: ");
      string firstArgument = Console.ReadLine();
      int firstNumber = int.Parse(firstArgument);

      Console.Write("Please enter the second number: ");
      string secondArgument = Console.ReadLine();
      int secondNumber = int.Parse(secondArgument);

      int answer = 0;

      if (op == "*")
      {
        answer = firstNumber*secondNumber;
      }
      else if (op == "/")
      {
        answer = firstNumber/secondNumber;
      }
      else if (op == "+")
      {
        answer = firstNumber + secondNumber;
      }
      else if (op == "-")
      {
        answer = firstNumber - secondNumber;
      }

      Console.WriteLine("The answer is: " + answer);

      Console.ReadLine();
    }
  }
}
