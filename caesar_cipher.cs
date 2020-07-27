using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("Hello, please write your first message");
      string message = Console.ReadLine();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for (int i = 0; i < secretMessage.Length; i++)
      {
        char letter = secretMessage[i];
        int letterPossition = Array.IndexOf(alphabet, letter);
        int newLetterPossition = (letterPossition + 3) % alphabet.Length;
        char letterEncoded = alphabet[newLetterPossition];
        encryptedMessage[i] = letterEncoded;
      }
      string encodedString = String.Join("", encryptedMessage);
      Console.WriteLine($"Your encoded message is: {encodedString} ");
    }
  }
}