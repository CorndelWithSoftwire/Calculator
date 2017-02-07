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
      var logger = new Logger();

      PrintWelcomeMessage();

      while (true)
      {
        int calculationMode = AskForCalculationMode();

        if (calculationMode == NumberCalculator)
        {
          new NumberCalculator(logger).PerformOneCalculation();
        }
        else
        {
          new DateCalculator(logger).PerformOneCalculation();
        }
      }
    }

    private static void PrintWelcomeMessage()
    {
      Console.WriteLine("Welcome to the calculator!");
      Console.WriteLine("==========================");
    }

    private static int AskForCalculationMode()
    {
      Console.WriteLine("Which calculator mode do you want?");
      Console.WriteLine(" {0}) Numbers", NumberCalculator);
      Console.WriteLine(" {0}) Dates", DateCalculator);
      return Prompts.AskForNumber("> ");
    }
  }
}
