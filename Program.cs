/*
In this project, I build a C# program that presents a quiz the right way (checking if user input is correct format): 
using arrays and loops, it will check the format of user input and repeat the question if the format is incorrect. 
After the quiz is complete, it will check the user’s responses against the correct answers and present a score.
*/

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
      

      // Type your code below
      string[] questions = new string[] 
      {"A lion's roar can be heard up to eight kilometers away.", "Monaco is the smallest country in the world.", "There are five different blood groups.", "An octopus has three hearts.", "The only letter not in the periodic table is the letter J."};

      // Correct answers
      bool[] answers = new bool [] 
      {true, false, false, true, true};

      RunQuiz(questions, answers);
    }

    static void RunQuiz(string[] questions, bool[] answers) 
    {
      // User replies
      bool[] responses = new bool[questions.Length];

      // Write an if statement that checks if the length of the questions array is not equal to the length of the answers array
      if (questions.Length != answers.Length) 
      {
        Console.WriteLine("Warning! The number of questions and answers are unequal.");
      }

      // Ask questions and capture user input
      int askingIndex = 0;

      foreach (string question in questions) 
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(questions[askingIndex]);
        Console.WriteLine("True or False?");
        input = Console.ReadLine();

        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool) 
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = Convert.ToBoolean(input);
        askingIndex++;
      }
        
      // Now calculate score
      int scoringIndex = 0;
      int score = 0;

      foreach (bool answer in answers) 
      {
        bool response = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");

        if (response == answer) 
        {
          score++;
        }

        scoringIndex++;

      }

      Console.WriteLine($"You got {score} out of {answers.Length} correct.");

    }
  }
}

