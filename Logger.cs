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
      File.AppendAllText(LogFile, string.Format("{0} = {1}{2}", question, answer, Environment.NewLine));
    }
  }
}