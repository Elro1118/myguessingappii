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

    static string respUser = "n";

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

      Console.WriteLine("Think of a number between 1 and 100! Press y/n when you are ready!");
      respUser = Console.ReadLine();

      while ((respUser != "n") && (respUser != "y"))
      {
        Console.WriteLine("Please, press y/n for answering the question!");
        respUser = Console.ReadLine();
      }

      while (stillGuessing == "n")
      {
        guess = Convert.ToInt16(Math.Floor(Convert.ToDecimal((lower + upper) / 2)));
        Console.WriteLine("Is your number " + guess + " ? Press y/n! ");
        stillGuessing = Console.ReadLine();

        while ((stillGuessing != "n") && (stillGuessing != "y"))
        {
          Console.WriteLine("Please, press y/n for answering the question!");
          stillGuessing = Console.ReadLine();
        }

        if (stillGuessing == "n")
        {
          Console.WriteLine("Is your number higher or lower? Press h/l!");
          typeSearch = Console.ReadLine();
          while ((typeSearch != "h") && (typeSearch != "l"))
          {
            Console.WriteLine("Please, press h/l for answering the question!");
            typeSearch = Console.ReadLine();
          }
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
