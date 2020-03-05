using System;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello. Tell me a word and I'll tell you secret");
      string response = Console.ReadLine();
      Word newResponse = new Word(response);
      // try
      // {
        // string correctInput = newResponse.CheckInput();
        // Console.WriteLine(correctInput + "Is a great word!");
        int score = newResponse.GetScore();
        Console.WriteLine("your score is " + score);
      // }
      // catch (Exception ex)
      // {
      //   Console.WriteLine("Message = {0}", ex.Message);
      //   Console.WriteLine("Source = {0}", ex.Source);
      //   Console.WriteLine("StackTrace = {0}", ex.StackTrace);
      //   Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      //   Console.WriteLine("nice try, wise guy!");
      // }
    }
  }
}