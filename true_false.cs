using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string [] questions = new string []
      {
        "Eggplants aren't REALLY vegetables, they're berries", "Eggplants and tomatoes are actually related", "People in the U.K. called them aubergines", "Japan has a proverb about eggplant"
      };
      bool[] answers = new bool[]
      {
        true,
        true,
        true,
        true
      };
      bool[] responses = new bool[questions.Length];
      
      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Warning! The length of the question doesn't equal the length answer.");
      }
      int askingIndex = 0;
      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out isBool) ;
          
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }
      int scoringIndex = 0;
      int score = 0;

      foreach (bool answer in answers)
      {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex + 1 + ".");
        Console.WriteLine($"Input: {response} | Answer: {answer}");

        if (response == answer)
        {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
  }
}
