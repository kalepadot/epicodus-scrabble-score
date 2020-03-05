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
     int score = newResponse.GetScore();
     Console.WriteLine("your score is " + score);
    }
  }
}