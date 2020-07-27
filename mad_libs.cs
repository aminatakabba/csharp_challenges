using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is going to create sentences according to the user input
      Author: Aminata Kabba
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Welcome to Mad Libs");


      // Give the Mad Lib a title:
      string title = "The life of a beautiful princess";

      Console.WriteLine(title);
      // Define user input and variables:

      // Name
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();

      // Adjectives
      Console.WriteLine("Enter an adjective: ");
      string adj1 = Console.ReadLine();

      Console.WriteLine("Enter a second adjective: ");
      string adj2 = Console.ReadLine();

      Console.WriteLine("Enter a third adjective: ");
      string adj3 = Console.ReadLine();

      // Verbs
      Console.WriteLine("Enter a verb: ");
      string verb = Console.ReadLine();
      
      // Noun
      Console.WriteLine("Enter a noun: ");
      string noun1 = Console.ReadLine();

      Console.WriteLine("Enter a second noun: ");
      string noun2 = Console.ReadLine();

      // User input for anima, food, fruit, superhero, county, dessert, and year
      Console.WriteLine("Enter an animal: ");
      string animal = Console.ReadLine();

      Console.WriteLine("Enter an food: ");
      string food = Console.ReadLine();

      Console.WriteLine("Enter an fruit: ");
      string fruit = Console.ReadLine();

      Console.WriteLine("Enter an superhero: ");
      string superhero = Console.ReadLine();

      Console.WriteLine("Enter an country: ");
      string country = Console.ReadLine();

      Console.WriteLine("Enter an dessert: ");
      string dessert = Console.ReadLine();

      Console.WriteLine("Enter an year: ");
      string year = Console.ReadLine();
      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}\'s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}\'s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}\'s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
