﻿using System;
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
      Console.WriteLine($"What's your date of birth? ({CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern})");

      var userInput = Console.ReadLine();

      if (DateTimeOffset.TryParse(userInput, out var parsedDate)) // can add var parsedDate inline in C#8
        return parsedDate;
      else
      {
        Console.WriteLine($"Oops, you entered an invalid date...\n");

        return AskForDateOfBirth();
      }
    }
  }
}
