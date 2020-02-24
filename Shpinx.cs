using System;
using System.Collections.Generic;

class RiddlesOfSphinx
{
  static void Main()
  {
    Console.WriteLine("What goes on four feet in the morning, two feet at noon, and three feet in the evening?");
    string answer = Console.ReadLine();
    string lowerCaseAnswer = answer.ToLower();
    if (lowerCaseAnswer == "human" || lowerCaseAnswer == "man")
    {
      Console.WriteLine("Correct!");
      Console.WriteLine("What has hands but no arms and a face but no eyes?");
      string answer2 = Console.ReadLine();
      string lowerCaseAnswer2 = answer2.ToLower();
      if (lowerCaseAnswer2 == "clock")
      {
        Console.WriteLine("Correct!");
        Console.WriteLine("");
      }
       else 
      {
      Console.WriteLine("You lose!");
      Main();
      }
    }
    else 
    {
      Console.WriteLine("You lose!");
      Main();
    }
  }
}