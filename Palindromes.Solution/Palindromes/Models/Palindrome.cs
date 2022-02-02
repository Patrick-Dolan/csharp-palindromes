using System;
using System.Collections.Generic;
namespace Palindromes
{
  public class Palindrome
  {
    public string UserInput {get; set;}
    public Palindrome(string userInput)
    {
      UserInput = userInput;
    }
    public static string ReverseString(string userInput)
    {
      char[] charArray = userInput.ToCharArray();
      string reversedString = "";
      Array.Reverse(charArray);
      reversedString = string.Join("", charArray);
      return reversedString;
    }
  }
}