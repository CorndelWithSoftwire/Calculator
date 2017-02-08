using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
  public class NumberCalculator : ICalculator
  {
    private Logger logger;

    public NumberCalculator(Logger logger)
    {
      this.logger = logger;
    }

    public void PerformOneCalculation()
    {
      var op = Prompts.AskForString("Please enter the operator: ");
      var numbers = Prompts.AskForNumberArray($"Please enter the numbers to {op}. ");
      var answer = CalculateAnswer(op, numbers);

      logger.LogCalculation(string.Join(op, numbers), answer.ToString());
      Console.WriteLine("The answer is: {0}", answer);
      Console.WriteLine();
    }

    private int CalculateAnswer(string op, List<int> numbers)
    {
      switch (op)
      {
        case "*":
          return numbers.Aggregate(1, (acc, number) => acc*number);

        case "/":
          return numbers.Skip(1).Aggregate(numbers[0], (acc, number) => acc/number);

        case "+":
          return numbers.Sum();

        case "-":
          return numbers.Skip(1).Aggregate(numbers[0], (acc, number) => acc - number);

        default:
          throw new InvalidOperatorException(op);
      }
    }
  }
}