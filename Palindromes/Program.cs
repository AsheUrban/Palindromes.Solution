using System;
// using System.Collections.Generic;
using PChecker.Models;

namespace PChecker
{
  public class Program 
  {
    public static void Main()
    {

      Console.WriteLine("Enter a word to learn if it is a palindrome: ");
      string userInputWord = Console.ReadLine(); 
      Console.WriteLine("You entered: " + userInputWord);

      Palindrome userInput1 = new Palindrome(userInputWord);

      Console.WriteLine(userInput1);
  

      // if (userInput1.IsPalindrome())
      // {
      //     // Console.WriteLine("YAY");
      //     // Console.WriteLine(revArray);
      // } 
      // else
      // {
      //   // Console.WriteLine("Sorry, that is not a palindrome! Try again!");
      // }

    }
  }

}
