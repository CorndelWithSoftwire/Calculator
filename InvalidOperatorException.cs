using System;

namespace Calculator
{
  public class InvalidOperatorException : Exception
  {
    public InvalidOperatorException(string op) : base(string.Format("The operation {0} is not supported.", op))
    {
    }
  }
}