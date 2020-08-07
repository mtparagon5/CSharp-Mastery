using System;

namespace _4.GuessingGameChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      // get user's name
      var usersName = GetUsersName();

      // introduce the game to the user
      ComeOnDown(usersName);

      // get random number betwwen 0 and 100
      var numberToGuess = new Random().Next(101);

      // initialize counter
      var counter = 0;

      // play the guessing game with user
      LetsPlay(usersName, numberToGuess, counter);
    }

    /// <summary>
    /// Get the users name
    /// </summary>
    /// <returns>The users name or given input</returns>
    public static string GetUsersName()
    {
      // say hello / ask for name
      Console.WriteLine("Hi there! What's your name?\n");

      // return the users input
      return Console.ReadLine();
    }

    /// <summary>
    /// Introduce the user to the game and provide a little banter :)
    /// </summary>
    /// <param name="usersName">This is the input given by the user when asked for their name</param>
    public static void ComeOnDown(string usersName)
    {
      // introduce the game to the user
      Console.WriteLine($"\nCome on down, {usersName}, let's play a guessing game!\r\n");

      // challenge the user with a little banter
      Console.WriteLine($"I hear you're pretty smart...Let's see how smart you are!\r\n");
    }

    /// <summary>
    /// Time to play! This begins or continues the game
    /// </summary>
    /// <param name="usersName">The users name or given input</param>
    /// <param name="numberToGuess">The random number to be guessed (0 to 100)</param>
    /// <param name="counter">A counter to track the users progress</param>
    public static void LetsPlay(string usersName, int numberToGuess, int counter)
    {
      // increment counter
      counter++;

      // Present the game to the user
      Console.WriteLine("I'm thinking of a number between 0 and 100, give it your best guess!");

      // if the user entered a valid integer...
      if (int.TryParse(Console.ReadLine(), out var usersGuess))
      {
        // if the users guess is 0 to 100...
        if (usersGuess >= 0 && usersGuess <= 100)
        {
          // if the user guessed incorrectly...
          if (usersGuess != numberToGuess)
          {
            // let the user know if they're low or high
            Console.WriteLine($"\nSorry, you're guess of {usersGuess} was too {(usersGuess < numberToGuess ? "low" : "high")}...try again\r\n");

            // continue play
            LetsPlay(usersName, numberToGuess, counter);
          }
          // if the user guessed correctly...
          else
          {
            // if the user got it on the first try...
            if (counter == 1)
              // Congratulate the user on guessing the correct number in the first try
              Console.WriteLine($"\r\nWow {usersName}, you really are smart! You got it right on the first try!");

            // if the user got it within the first 5 tries...
            else if (counter > 1 && counter <= 5)
              // Congratulate the user on guessing the correct number in < 5 times
              Console.WriteLine($"\r\nWell done, {usersName}! It only took you {counter} guesses!");

            // otherwise...
            else
              // Congratulate the user on finally guessing the correct number
              Console.WriteLine($"\r\nWell, {usersName}, it might have taken a while, but you finally got it! Great job!");
          }
        }
        // if the user entered an integer outside the bounds of the game...
        else
        {
          // tell the user the 
          Console.WriteLine("Numbers are hard, I know...try again by guessing between 0 and 100 ;)\r\n");

          // continue play
          LetsPlay(usersName, numberToGuess, counter);
        }
      }
      // if the user did not enter a valid integer...
      else
      {
        // let the user know they need to enter an integer
        Console.WriteLine("Oops, it seems you've entered an invalid integer...try again");

        // continue play
        LetsPlay(usersName, numberToGuess, counter);
      }
    }
  }
}
