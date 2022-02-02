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
      foreach (char character in charArray)
      {
        reversedString = character + reversedString;
      }
      return reversedString;
    }
  }
}