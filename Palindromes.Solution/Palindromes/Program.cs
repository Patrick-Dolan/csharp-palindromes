using System;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Console.Write("Enter a word to check if its a palindrome: ");
      string userInput = Console.ReadLine();
      Palindrome word = new Palindrome(userInput);
      Console.WriteLine(Palindrome.ReverseString(word.UserInput));
    }
  }
}