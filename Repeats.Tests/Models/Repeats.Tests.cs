using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Repeats.Models;

namespace Repeats.Tests
 {
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetsAndSets_AllGettersAndSetters_Green()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      //action
      newRepeatCounter.SetTestWord("Hello ");
      newRepeatCounter.SetTargetString("Hello World");
      newRepeatCounter.SetRepeatsCounter(2);
      newRepeatCounter.SetTargetStringList("Hello World");
      string testWord = newRepeatCounter.GetTestWord();
      List<string> testingListRemovals = newRepeatCounter.GetRemovals();
      string removalIndexTwo = testingListRemovals[2];
      string targetString = newRepeatCounter.GetTargetString();
      int repeatInt = newRepeatCounter.GetRepeats();
      List<string> testingList = newRepeatCounter.GetTargetStringList();
      string TargetStringListIndexOne = testingList[1];
      //assert
      Assert.AreEqual("Hello", testWord);
      Assert.AreEqual("!", removalIndexTwo);
      Assert.AreEqual("Hello World", targetString);
      Assert.AreEqual(2, repeatInt);
      Assert.AreEqual("World", TargetStringListIndexOne);
    }


    [TestMethod]
    public void CleanTargetStrings_RemoveAsterix_Red()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      //action
      string newTargetString = "Hell*o Wo*rld";
      newRepeatCounter.SetTargetStringList(newTargetString);
      newRepeatCounter.CleanTargetStrings();
      List<string> testingList = newRepeatCounter.GetTargetStringList();
      string TargetStringListIndexOne = testingList[1];
      //assert

      Assert.AreEqual("World", TargetStringListIndexOne);
    }

    [TestMethod]
    public void GetsAndSets_AllGettersAndSetters_Green()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      //action

      //assert

      Assert.AreEqual("World", TargetStringListIndexOne);
    }

    [TestMethod]
    public void GetsAndSets_AllGettersAndSetters_Green()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      //action

      //assert

      Assert.AreEqual("World", TargetStringListIndexOne);
    }

    [TestMethod]
    public void GetsAndSets_AllGettersAndSetters_Green()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      //action

      //assert

      Assert.AreEqual("World", TargetStringListIndexOne);
    }



  }
}
