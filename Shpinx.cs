using System;
using System.Collections.Generic;

public class RiddlesOfSphinx
{
  public string Riddle;
  public string Answer;
}

public class Riddle
{
  public static void Main()
  {
    RiddlesOfSphinx one = new RiddlesOfSphinx();
    one.Riddle = "What goes on four feet in the morning, two feet at noon, and three feet in the evening?";
    one.Answer = "human";

    RiddlesOfSphinx two = new RiddlesOfSphinx();
    two.Riddle = "What has hands but no arms and a face but no eyes?";
    two.Answer = "clock";

    List<RiddlesOfSphinx> Riddles = new List<RiddlesOfSphinx>() { one, two };

    foreach(RiddlesOfSphinx eachRiddle in Riddles)
    {
      Console.WriteLine(eachRiddle.Riddle);
      string answer = Console.ReadLine();
      string lowerCaseAnswer = answer.ToLower();
      if (lowerCaseAnswer == eachRiddle.Answer)
      {
        Console.WriteLine("Correct!");
      }
      else
      {
        Console.WriteLine("You lose!");
        Main();
      }
    }
  }
}