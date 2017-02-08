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
      var calculators = new Dictionary<CalculatorType, ICalculator>
      {
        {CalculatorType.Number, new NumberCalculator(logger)},
        {CalculatorType.Date, new DateCalculator(logger)}
      };

      PrintWelcomeMessage();

      while (true)
      {
        try
        {
          CalculatorType calculationMode = AskForCalculationMode();
          calculators[calculationMode].PerformOneCalculation();
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
