using System;
using System.Collections.Generic;
using System.Linq;

namespace PChecker.Models
{
  public class Palindrome
  {
    //Public auto-implemented properties
    public string UserInput {get; set; }

    // Constructor
    public Palindrome(string userInput)
    {
      UserInput = userInput;
    }

    public bool IsWord(string userInput1)
    {
      if (String.IsNullOrWhiteSpace(userInput1)) 
      {
        return false;
      } 
      else 
      {
        return true;
      }
    }

    public bool IsPalindrome(string userInput)
    {
      char[] uInput = userInput.ToCharArray();
      char[] revArray = userInput.ToCharArray();
      Array.Reverse( revArray );
      
      if(Enumerable.SequenceEqual(uInput, revArray)) //Initially had userInput here and passed tests
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}