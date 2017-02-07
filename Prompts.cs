using System;

namespace Calculator
{
  class Prompts
  {
    public static int AskForNumber(string message)
    {
      int count;

      do
      {
        Console.Write(message);
      } while (!int.TryParse(Console.ReadLine(), out count));

      return count;
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

    public static int[] AskForNumberArray(string message)
    {
      var count = AskForNumber(message + "How many numbers do you want? ");

      int[] numbers = new int[count];
      for (int index = 0; index < count; index++)
      {
        numbers[index] = AskForNumber(string.Format("Please enter number {0}: ", index + 1));
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