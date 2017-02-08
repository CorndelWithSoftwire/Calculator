using System;

namespace Calculator
{
  public class InvalidOperatorException : Exception
  {
    public InvalidOperatorException(string op) : base($"The operation {op} is not supported.")
    {
    }
  }
}