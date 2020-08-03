using System;

namespace _2.Methods
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        string sargs = "Arguments: " + string.Join(", ", args);
        Console.WriteLine(sargs);
      }
      catch { }

      Console.WriteLine(GetUserDateOfBirth("Mary"));
    }

    // methods
    public static string GetUserDateOfBirth(string fullName)
    {

      return fullName + " was born on " + DateTime.Now.DayOfWeek;
    }
  }
}
