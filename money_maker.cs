using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
      string coins = Console.ReadLine();

      double myAgeAsDouble = Convert.ToDouble(coins);
      Console.WriteLine($"{myAgeAsDouble} cents is equal to...");

      // Coin values
      int goldValue = 10;
      int silverValue = 5;

      // Calculate number of coins fitting into the gold
      double goldCoins = Math.Floor(myAgeAsDouble/goldValue);
      double remainer = myAgeAsDouble % goldValue;

      // Calculate number of coins fitting into the silver
      double silverCoins = Math.Floor(remainer/silverValue);
      remainer = remainer % silverValue;
      Console.WriteLine(silverCoins);
      Console.WriteLine(remainer);
    }
  }
}