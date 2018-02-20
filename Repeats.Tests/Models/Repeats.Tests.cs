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
    public void CleanTargetStrings_RemoveAsterix_Green()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      //action
      newRepeatCounter.SetTargetStringList("Hell*o");
      newRepeatCounter.CleanTargetStrings();
      List<string> testingList = newRepeatCounter.GetTargetStringList();
      string TargetStringListIndexZero = testingList[0];
      //assert

      Assert.AreEqual("Hello", TargetStringListIndexZero);
    }

    [TestMethod]
    public void CompareStrings_CounterToTwo_Green()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      //action
      newRepeatCounter.SetTestWord(" Hello ");
      string test = newRepeatCounter.GetTestWord();
      newRepeatCounter.SetTargetStringList("Hell*o H@ello");
      newRepeatCounter.CleanTargetStrings();
      List<string> testList = newRepeatCounter.GetTargetStringList();
      newRepeatCounter.CompareStrings();
      int repeatInt = newRepeatCounter.GetRepeats();

      //assert

      Assert.AreEqual(2, repeatInt);
    }

    [TestMethod]
    public void CompareStrings_TestWordWithExclusion_Green()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      //action
      newRepeatCounter.SetTestWord(" #Hello ");
      newRepeatCounter.SetTargetStringList("#He$llo #H@ello hello @@way! &**) yay day");
      newRepeatCounter.SetRemovals();
      newRepeatCounter.CleanTargetStrings();
      newRepeatCounter.CompareStrings();
      int repeatInt = newRepeatCounter.GetRepeats();

      //assert

      Assert.AreEqual(2, repeatInt);
    }



  }
}
