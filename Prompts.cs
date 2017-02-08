using System;
using System.Collections.Generic;

namespace Calculator
{
  class Prompts
  {
    public static int AskForNumber(string message)
    {
      while (true)
      {
        int? maybeNumber = AskForOptionalNumber(message);

        if (maybeNumber.HasValue)
        {
          return maybeNumber.Value;
        }
      }
    }

    public static int? AskForOptionalNumber(string message)
    {
      while (true)
      {
        Console.Write(message);
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
          return null;
        }

        int number;
        if (int.TryParse(input, out number))
        {
          return number;
        }
      }
    }

    public static DateTime AskForDate(string message)
    {
      DateTime date;

      do
      {
        Console.Write(message);
      } while (!DateTime.TryParse(Console.ReadLine(), out date));

      return date;
    }

    public static List<int> AskForNumberArray(string message)
    {
      Console.WriteLine(message);
      List<int> numbers = new List<int>();

      while (true)
      {
        int? number = AskForOptionalNumber("  Please enter the next number: ");

        if (number.HasValue)
        {
          numbers.Add(number.Value);
        }
        else
        {
          break;
        }
      }

      return numbers;
    }

    public static string AskForString(string message)
    {
      Console.Write(message);
      string op = Console.ReadLine();
      return op;
    }
  }
}