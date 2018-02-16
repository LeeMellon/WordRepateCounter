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
      newRepeatCounter.SetTargetStringList();
      string testWord = newRepeatCounter.GetTestWord();
      string removalIndexTwo = newRepeatCounter.GetRemovals[2];
      string targetString = newRepeatCounterGetTargetString();
      int repeatInt = newRepeatCounter.GetRepeats();
      string TargetStringListIndexTwo = newRepeatCounter.GetTargetStringList([1]);
      //assert
      Assert.AreEqual("Hello", testWord);
      Assert.AreEqual("#", removalIndexTwo);
      Assert.AreEqual("Hello World", targetString);
      Assert.AreEqual("2", repeatInt);
      Assert.AreEqual("World", TargetStringListIndexTwo);


    }
  }
}
