using System;
using System.IO;

namespace Calculator
{
  public class Logger
  {
    private const string LogFile = @"C:\Training\Calculator.txt";

    public Logger()
    {
      if (File.Exists(LogFile))
      {
        File.Delete(LogFile);
      }
    }

    public void LogCalculation(string question, string answer)
    {
      File.AppendAllText(LogFile, $"{question} = {answer}{Environment.NewLine}");
    }
  }
}