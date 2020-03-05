using System;

namespace Game.Models
{
  public class Word
  {
    public string ScrabbleWord { get; set; }
    
    public Word(string scrabbleWord)
    { 
      ScrabbleWord = scrabbleWord;
      // Add Score Counter that method adds up via GetScore method
    }

    public int GetScore()
    {
      string onePoint = "aeioulnrst";
      string twoPoint = "dg";
      string threePoint = "bcmp";
      string fourPoint = "fhvwy";
      string fivePoint = "k";
      string eightPoint = "jx";
      string tenPoint = "qz";
      int scoreCounter = 0;
      // string newWord = Scrabbleword.ToLower();
      char[] splitString = ScrabbleWord.ToCharArray();
      for(int i = 0; i < splitString.Length; i++)
        { 
        if (onePoint.Contains(splitString[i]))
        {
        scoreCounter++;
        }
        else if(twoPoint.Contains(splitString[i]))
        {
          scoreCounter+=2;
        }
        else if(threePoint.Contains(splitString[i]))
        {
          scoreCounter+=3;
        }
        else if(fourPoint.Contains(splitString[i]))
        {
          scoreCounter+=4;
        }
          else if(fivePoint.Contains(splitString[i]))
        {
          scoreCounter+=5;
        }
          else if(eightPoint.Contains(splitString[i]))
        {
          scoreCounter+=8;
        }
          else if(tenPoint.Contains(splitString[i]))
        {
          scoreCounter+=10;
        }
      }
      return scoreCounter;
    }
  }
}