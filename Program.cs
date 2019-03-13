using System;

namespace myguessingappii
{
  class Program
  {
    static int min = 1;
    static int max = 100;
    static int upper = 0;
    static int lower = 0;
    static int guess = 0;
    static string stillGuessing = "n";
    static string typeSearch = "h";

    static void Main(string[] args)
    {

      updateGame();
    }

    static void guessHigher()
    {
      lower = guess + 1;
    }

    static void guessLower()
    {
      upper = guess - 1;

    }

    static void updateGame()
    {
      upper = max;
      lower = min;

      Console.WriteLine("Think of a number between 1 and 100!");
      while (stillGuessing == "n")
      {
        guess = Convert.ToInt16(Math.Floor(Convert.ToDecimal((lower + upper) / 2)));
        Console.WriteLine("Is it your number " + guess + "y/n?");
        stillGuessing = Console.ReadLine();
        if (stillGuessing == "n")
        {
          Console.WriteLine("Is it your number higher or lower h/l?");
          typeSearch = Console.ReadLine();
        }

        if (typeSearch == "h")
        {
          guessHigher();
        }
        else
        {
          guessLower();
        }
      }
      Console.WriteLine("Your number is " + guess);


    }
  }
}
