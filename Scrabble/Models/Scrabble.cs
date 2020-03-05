using System;
using System.Collections.Generic;

namespace Game.Models
{
  public class Word
  {
    public string ScrabbleWord { get; set; }
    public Dictionary<string, int> ScoreKey = new Dictionary<string, int>(){{"aeioulnrst", 1},{"dg", 2},{"bcmp", 3},{"fhvwy", 4},{"k", 5},{"jx", 8},{"qz", 10}};
   
    
    public Word(string scrabbleWord)
    { 
      ScrabbleWord = scrabbleWord;
    }

    public int GetScore()
    {
      int scoreCounter = 0;
      // string newWord = Scrabbleword.ToLower();
      char[] splitString = ScrabbleWord.ToCharArray();
      for(int i = 0; i < splitString.Length; i++)
      { 
        foreach(KeyValuePair<string, int> item in ScoreKey)
        {
          if (item.Key.Contains(splitString[i]))
          {
            scoreCounter += item.Value;
          }
        }
      }
      return scoreCounter;
    }
  }
}