using System;

namespace Calculator
{
  public class DateCalculator : ICalculator
  {
    private Logger logger;

    public DateCalculator(Logger logger)
    {
      this.logger = logger;
    }

    public void PerformOneCalculation()
    {
      var date = Prompts.AskForDate("Please enter a date: ");
      var number = Prompts.AskForNumber("Please enter the number of days to add: ");
      var answer = date.AddDays(number);

      logger.LogCalculation($"{date:dd/MM/yyyy} + {number}", answer.ToString("dd/MM/yyyy"));
      Console.WriteLine("The answer is: {0:dd/MM/yyyy}", answer);
      Console.WriteLine();
    }
  }
}