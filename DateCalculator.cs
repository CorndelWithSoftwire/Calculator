using System;

namespace Calculator
{
  public class DateCalculator
  {
    public void PerformOneCalculation()
    {
      var date = Prompts.AskForDate("Please enter a date: ");
      var number = Prompts.AskForNumber("Please enter the number of days to add: ");
      var answer = date.AddDays(number);

      Console.WriteLine("The answer is: {0:dd/MM/yyyy}", answer);
      Console.WriteLine();
    }
  }
}