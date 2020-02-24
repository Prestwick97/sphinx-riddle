using System;
using System.Collections.Generic;

public class RiddlesOfSphinx
{
  public int Number;
  public string Riddle;
  public string Answer;
}

public class Riddle
{
  public static void Main()
  {
    RiddlesOfSphinx one = new RiddlesOfSphinx();
    //one.Number = 1;
    one.Riddle = "What goes on four feet in the morning, two feet at noon, and three feet in the evening?";
    one.Answer = "human";

    RiddlesOfSphinx two = new RiddlesOfSphinx();
    //two.Number = 2;
    two.Riddle = "What has hands but no arms and a face but no eyes?";
    two.Answer = "clock";

    RiddlesOfSphinx three = new RiddlesOfSphinx();
    //three.Number = 3;
    three.Riddle = "What has to be broken before you can use it?";
    three.Answer = "egg";

    RiddlesOfSphinx four = new RiddlesOfSphinx();
    //four.Number = 4;
    four.Riddle = "I’m tall when I’m young, and I’m short when I’m old. What am I?";
    four.Answer = "candle";

    RiddlesOfSphinx five = new RiddlesOfSphinx();
    //five.Number = 5;
    five.Riddle = "What is full of holes but still holds water?";
    five.Answer = "sponge";

    List<RiddlesOfSphinx> Riddles = new List<RiddlesOfSphinx>() { one, two, three, four, five };
 
    foreach(RiddlesOfSphinx eachRiddle in Riddles)
    {
      Random random = new Random();  
      int index = random.Next(1, 5); 
      Console.WriteLine(Riddles[index].Riddle);
      string answer = Console.ReadLine();
      string lowerCaseAnswer = answer.ToLower();
      if (lowerCaseAnswer == Riddles[index].Answer)
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