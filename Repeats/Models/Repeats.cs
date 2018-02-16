using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Repeats.Models
{
    public class RepeatCounter
    {
      private string _testWord;
      private string _targetString;
      private List<string> _targetStringList;
      private int _repeats;
      private List<string> _removals = new List<string>(){
        "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+","=","-","0","9","8","7","6","5","4", "3","2","1","{","}","[", "]", """, "'",";",":", "?","/",">",".",","<"}


    }

}
