using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text;


namespace Repeats.Models
{
    public class RepeatCounter
    {
      private string _testWord;
      private string _targetString;
      private List<string> _targetStringList;
      private int _repeats;
      private List<string> _removals = new List<string>(){
        "{", "}", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "=", "-", "0", "9", "8", "7", "6", "5", "4", "3", "2", "1", "'", ";", ":", "?", "/", ">", ".", ",", "<"};


      public string GetTestWord()
      {
        return _testWord;
      }

      public string GetTargetString()
      {
        return _targetString;
      }

      public List<string> GetRemovals()
      {
        return _removals;
      }

      public int GetRepeats()
      {
        return _repeats;
      }

      public List<string> GetTargetStringList()
      {
        return _targetStringList;
      }

      public void SetTestWord(string newTestWord)
      {
        _testWord = newTestWord.Trim();
      }

      public void SetTargetString(string newTargetString)
      {
        _targetString = newTargetString;
      }

      public void SetRepeatsCounter (int newCounter)
      {
        _repeats = newCounter;
      }

      public void SetTargetStringList(string newString)
      {
        string[] split = newString.Split(' ');
        List<String> newList=new List<string>(split);
        _targetStringList = newList;
      }

      public void CleanTargetStrings()
      {
        List<string> newTargetList = new List<string>();
        foreach(string word in _targetStringList)
        {
          foreach(string item in _removals)
          {
            if (word.Contains(item))
            {
              string replacementString = word.Replace(item, "");
              newTargetList.Add(replacementString);
            }
          }
        }
         _targetStringList = newTargetList;

      }



  }
}
