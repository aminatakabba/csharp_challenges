using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      int score = 0;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuwxyz";
      string digits = "0123456789";
      string specialChars = "~!@#$%^&-";

      Console.WriteLine("Write a valid password: ");
      string password = Console.ReadLine();
      if (password.Length >= score)
      {
        score += 1;
      }
      else if (Tools.Contains(password, uppercase))
      {
        score += 1;
      }
      else if (Tools.Contains(password, lowercase))
      {
        score += 1;
      }
      else if (Tools.Contains(password, digits))
      {
        score += 1;
      }
      else if (Tools.Contains(password, specialChars))
      {
        score += 1;
      }
      switch(score)
      {
      case 5:
      case 4:
        Console.WriteLine("The password is extremely strong");
        break;
      case 3:
        Console.WriteLine("The password is strong");
        break;
      case 2:
        Console.WriteLine("The password is medium");
        break;
      case 1:
        Console.WriteLine("The password is weak");
        break;
      default:
        break;
    }
    }
  }
}

