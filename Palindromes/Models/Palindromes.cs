using System;

namespace PChecker
{
  public class Palindrome
  {
    public bool IsWord(string userInput)
    {
      if (String.IsNullOrEmpty(userInput)) 
      {
        return false;
      } 
      else 
      {
        return true;
      }
    }
  }
}