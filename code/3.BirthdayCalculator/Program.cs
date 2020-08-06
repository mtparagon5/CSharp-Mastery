using System;
using System.Globalization;

namespace _3.BirthdayCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // introduce paul robot to user
      IntroducePaul();

      // ask for and store user's date of birth
      var usersDateOfBirth = AskForDateOfBirth();

      AnnounceDateOfBirthInformation(usersDateOfBirth);
    }

    /// <summary>
    /// Introduces robot to the user
    /// </summary>
    public static void IntroducePaul()
    {
      // output message to user
      Console.WriteLine("Hi, I'm Paul!\nI bet I can guess what day of the week you were born on! C'mon I'll show you!");
    }

    /// <summary>
    /// Asks the user for their date of birth until given in correct format
    /// </summary>
    /// <remarks>
    /// This call will not return until valid date is given or application is terminated
    /// </remarks>
    /// <returns>The date of birth the user entered</returns>
    public static DateTimeOffset AskForDateOfBirth()
    {
      // Create checked date with out of range initial value
      var dateOfBirth = DateTimeOffset.MaxValue;

      // Until the date of birth is greater than today...
      while (dateOfBirth > DateTimeOffset.UtcNow)
      {
        // Ask user for their date of birth and display required format
        Console.WriteLine($"What's your date of birth? ({CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern})");

        // read/store the user's response
        var userInput = Console.ReadLine();

        // if the user entered a valid date...
        if (DateTimeOffset.TryParse(userInput, out var parsedDate)) // can add var parsedDate inline in C#8
          // set checked date to users given date
          dateOfBirth = parsedDate;
        // otherwise...
        else
        {
          // inform user their input is invalid
          Console.WriteLine($"Oops, you entered an invalid date...\n");
        }
      }
      // return the result
      return dateOfBirth;
    }

    /// <summary>
    /// Display information to the user about their provided date of birth
    /// </summary>
    /// <param name="date">The date to provide information about</param>
    public static void AnnounceDateOfBirthInformation(DateTimeOffset date)
    {
      // store current time
      var now = DateTimeOffset.UtcNow;

      // Display date of birth and day of the week they were born
      Console.WriteLine($"So you were born on {date:MMMM d, yyyy}, which (fun fact #1!) would have been a {date.DayOfWeek} that year!\n");

      // Indicate whether we've already past the user's bday for this current year
      var hasPassedBirthday = DateTimeOffset.UtcNow.DayOfYear > date.DayOfYear;

      // get a date representing the user's next birthday
      var nextBirthday = new DateTimeOffset(DateTimeOffset.UtcNow.Year + (hasPassedBirthday ? 1 : 0), date.Month, date.Day, 0, 0, 0, TimeSpan.Zero);

      // calculate number of days until next birthday
      var daysTilNextBirthday = (nextBirthday - DateTimeOffset.UtcNow).TotalDays;

      // calculate user's age
      var usersAge = now.Year - date.Year - (hasPassedBirthday ? 0 : 1); // if have not passed birthday, need to subtract 1 more year.

      // Display happy birthday if it's the user's bday or number of day's until next birthday
      Console.WriteLine((daysTilNextBirthday > 364 ? $"Well look at that! Today is your birthday :) HAPPY BIRTHDAY!!!\n" : $"Oh wow, your next birthday is in {daysTilNextBirthday:0} days!\n"));

      // calculate time alive
      var timeAlive = now - date;

      // Display user's time alive and age in human years and dog years
      Console.WriteLine($"Fun fact #2! It looks like you've been alive {timeAlive.TotalDays:n0} days, " +
                          $"{timeAlive.TotalHours:n0} hours, " +
                          $"{timeAlive.TotalMinutes:n0} minutes, " +
                          $"{timeAlive.TotalSeconds:n0} seconds, " +
                          $"and are {usersAge} years {(usersAge < 40 ? "old!" : "young ;)")} (...or {usersAge * 7} in dog years :P ) \n");
    }
  }
}
