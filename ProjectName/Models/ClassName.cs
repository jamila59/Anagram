using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System;

namespace ToDoList.Models
{

  public class Item
  {
     private string _mainWord;
     private string[] _mainList; 

     public Item(string mainword, string[] mainList) 
     {
        _mainList = mainList;
        _mainWord = mainword;
     }
     public string GetMainWord()
     {
       return _mainWord;
     }
     public string[] GetMainList()
     {
       return _mainList;
     }

     public List <string> CheckAnagram()
     {
       List <string> output = new List <string>{}; // makes new list
       char [] mainCharArr = _mainWord.ToCharArray(); //splits word into an array of char
       Array.Sort(mainCharArr);    // Sorts array 
       string sortedMainWord = String.Join(" ", mainCharArr); // puts the array back together

       for ( int i = 0; i < _mainList.Length; i ++)
       {
         char [] testCharArray = _mainList[i].ToCharArray(); //takes words from array and splits into array of char
         Array.Sort(testCharArray); // sorts array 
         string sortedTestArray = String.Join(" ", testCharArray);
         if (sortedMainWord == sortedTestArray)
         {
           output.Add(_mainList[i]);
         }
       }
       return output;
    }
  }
}