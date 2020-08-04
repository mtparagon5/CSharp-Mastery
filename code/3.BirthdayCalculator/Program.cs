using System;
using System.Globalization;

namespace _3.BirthdayCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      IntroducePaul();
      var usersDateOfBirth = AskForDateOfBirth();
    }

    public static void IntroducePaul()
    {
      Console.WriteLine("Hi, I'm Paul!\nI bet I can guess what day of the week you were born on! C'mon I'll show you!");
    }

    public static DateTimeOffset AskForDateOfBirth()
    {

      // while loop to avoid recursion - see original if/else loop below
      while (true)
      {
        // Ask user for bday
        Console.WriteLine($"What's your date of birth? ({CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern})");
        // store user input
        var userInput = Console.ReadLine();

        // validate user input
        if (DateTimeOffset.TryParse(userInput, out var parsedDate)) // can add var parsedDate inline in C#8
          // if valid - break while loop
          return parsedDate;
        // if invalid - repeat
        else
        {
          Console.WriteLine($"Oops, you entered an invalid date...\n");
        }
      }

      // old
      //if (DateTimeOffset.TryParse(userInput, out var parsedDate)) // can add var parsedDate inline in C#8
      //  return parsedDate;
      //else
      //{
      //  Console.WriteLine($"Oops, you entered an invalid date...\n");

      //  return AskForDateOfBirth();
      //}
    }
  }
}
