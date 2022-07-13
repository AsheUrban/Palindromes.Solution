using System;
// using System.Collections.Generic;
using PChecker.Models;

namespace PChecker.Models
{
  public class Program // does this need to be Solution???
  {
    public static void Main()
    {

      Console.WriteLine("Enter a word to learn if it is a palindrome: ");
      string userInputWord = Console.ReadLine(); 
      Console.WriteLine("You entered: " + userInputWord);

      // Palindrome userInput1 = new Palindrome(userInputWord);

      // if (userInput1.IsPalindrome(""))
      // {
      //     Console.WriteLine(userInput1);
      //     Console.WriteLine(revArray);
      // } 
      // else
      // {
      //   Console.WriteLine("Sorry, that is not a palindrome! Try again!");
      // }

    }
  }

}
