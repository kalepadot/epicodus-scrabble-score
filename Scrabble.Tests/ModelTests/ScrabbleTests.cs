using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System;

namespace Game.Tests
{
  [TestClass]
  public class MakeFilesTests
  {
    [TestMethod]
    public void WordConstructor_CreateNewInstance_Word()
    {
      // Arrange
      string scrabbleWord = "Haru";
      Word newWord = new Word(scrabbleWord);
      // Act
      // Assert
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
    [TestMethod]
    public void GetScore_CalculateScore_Int()
    {
      // arrange
      string scrabbleWord = "ae";
      Word newWord = new Word(scrabbleWord);
      // act
      int score = newWord.GetScore();
      // assert
      Assert.AreEqual(2, score);
    }
    [TestMethod]
    public void GetScore_Calculate2Points_Int()
    {
      // arrange
      string scrabbleWord = "dog";
      Word newWord = new Word(scrabbleWord);
      // act
      int score = newWord.GetScore();
      // assert
      Assert.AreEqual(5, score);
    }
      [TestMethod]
    public void GetScore_Calculate3Points_Int()
    {
      // arrange
      string scrabbleWord = "camp";
      Word newWord = new Word(scrabbleWord);
      // act
      int score = newWord.GetScore();
      // assert
      Assert.AreEqual(10, score);
    }
    [TestMethod]
    public void GetScore_Calculate4Points_Int()
    {
      // arrange
      string scrabbleWord = "four";
      Word newWord = new Word(scrabbleWord);
      // act
      int score = newWord.GetScore();
      // assert
      Assert.AreEqual(7,score);
    }
    [TestMethod]
    public void GetScore_Calculate5Points_Int()
    {
            // arrange
      string scrabbleWord = "kool";
      Word newWord = new Word(scrabbleWord);
      // act
      int score = newWord.GetScore();
      // assert
      Assert.AreEqual(8,score);
    }
      [TestMethod]
      public void GetScore_Calculate8Points_Int()
    {
            // arrange
      string scrabbleWord = "jeremy";
      Word newWord = new Word(scrabbleWord);
      // act
      int score = newWord.GetScore();
      // assert
      Assert.AreEqual(18,score);
  }
      [TestMethod]
      public void GetScore_Calculate10Points_Int()
    {
            // arrange
      string scrabbleWord = "zoro";
      Word newWord = new Word(scrabbleWord);
      // act
      int score = newWord.GetScore();
      // assert
      Assert.AreEqual(13,score);
    }
  }
}