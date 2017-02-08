using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  class Program
  {
    enum CalculatorType
    {
      Number = 1,
      Date = 2
    }

    static void Main(string[] args)
    {
      var logger = new Logger();

      PrintWelcomeMessage();

      while (true)
      {
        try
        {
          CalculatorType calculationMode = AskForCalculationMode();

          if (calculationMode == CalculatorType.Number)
          {
            new NumberCalculator(logger).PerformOneCalculation();
          }
          else
          {
            new DateCalculator(logger).PerformOneCalculation();
          }
        }
        catch (InvalidOperatorException e)
        {
          Console.WriteLine("Sorry, there was a problem: " + e.Message);
          Console.WriteLine();
        }
      }
    }

    private static void PrintWelcomeMessage()
    {
      Console.WriteLine("Welcome to the calculator!");
      Console.WriteLine("==========================");
    }

    private static CalculatorType AskForCalculationMode()
    {
      Console.WriteLine("Which calculator mode do you want?");
      Console.WriteLine(" {0}) Numbers", (int)CalculatorType.Number);
      Console.WriteLine(" {0}) Dates", (int)CalculatorType.Date);
      return (CalculatorType)Prompts.AskForNumber("> ");
    }
  }
}
