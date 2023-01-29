using System;
using System.Collections.Generic;

class Driver {
  public static void Main(string[] args) {
    Quiz my_quiz = new Quiz();
    int choice;

    do {
      Console.WriteLine("What would you like to do?");
      Console.WriteLine("1. Add a question to the quiz");
      Console.WriteLine("2. Remove a question from the quiz");
      Console.WriteLine("3. Modify a question in the quiz");
      Console.WriteLine("4. Take the quiz");
      Console.WriteLine("5. Quit");

      string rawInput = Console.ReadLine();
      choice = Int32.Parse(rawInput);

      if (choice == 1) {
        my_quiz.add_question();
      } else if (choice == 2) {
          my_quiz.remove_question();
      } else if (choice == 3) {
          my_quiz.modify_question();
      } else if (choice == 4) {
          my_quiz.give_quiz();
      }

    } 
    while (choice != 5);
  }
}

class Question {
  private string question;
  private string answer;
  private int diff;

  //Constructor
  public Question(string question, string answer, int diff) {
      this.question = question;
      this.answer = answer;
      this.diff = diff;
  }

  //Getters
  public string getQuestion() {
    return question;
  }

  public string getAnswer() {
    return answer;
  }

  public int getQuestionDifficulty() {
    return diff;
  }

  //Setters
  public void setQuestion(string question) {
    this.question = question;
  }

  public void setAnswer(string answer) {
    this.answer = answer;
  }

  public void setDifficulty(int diff) {
    this.diff = diff;
  }
}

class Quiz {
  private List<Question> quiz = new List<Question>();

  public void add_question() {
    Console.WriteLine("What is the Question Text?");
    string question = Console.ReadLine();
    Console.WriteLine("What is the Answer?");
    string answer = Console.ReadLine();
    Console.WriteLine("How Difficult (1-3)?");
    string rawDiff = Console.ReadLine();
    int diff = Int32.Parse(rawDiff);

    Question q = new Question(question, answer, diff);
      quiz.Add(q);
  }

  public void remove_question() {
    Console.WriteLine("Choose the question to remove:");

    for (int i = 0; i < quiz.Count; i++) {
      Console.WriteLine(i + ". " + quiz[i].getQuestion());
    }
    
    string rawInput = Console.ReadLine();
    int choice = Int32.Parse(rawInput);
    quiz.Remove(quiz[choice]);
  }

  public void modify_question() {
    Console.WriteLine("Choose the question to modify:");

    for (int i = 0; i < quiz.Count; i++) {
      Console.WriteLine(i + ". " + quiz[i].getQuestion());
    }
    
    string rawInput = Console.ReadLine();
    int choice = Int32.Parse(rawInput);

    Console.WriteLine("What is the Question Text?");
    string question = Console.ReadLine();
    Console.WriteLine("What is the Answer?");
    string answer = Console.ReadLine();
    Console.WriteLine("How Difficult (1-3)?");
    string rawDiff = Console.ReadLine();
    int diff = Int32.Parse(rawDiff);

    quiz[choice].setQuestion(question);
    quiz[choice].setAnswer(answer);
    quiz[choice].setDifficulty(diff);
  }

  public void give_quiz() {
    int score = 0;

    foreach (Question q in quiz) {
      Console.WriteLine(q.getQuestion());
      string guess = Console.ReadLine();
      if (guess.Equals(q.getAnswer())) {
        Console.WriteLine("Correct");
        score++;
      } else {
          Console.WriteLine("Incorrect");
      }
    }

    Console.WriteLine("You got " + score + " out of " + quiz.Count);
  }
} 