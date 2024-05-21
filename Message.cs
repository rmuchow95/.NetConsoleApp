namespace ConsoleApp;

public class Message //the class is public (accessibility)
{

  public void WhatILikeMessages()
  {//Creates a new line in the terminal (line break) with each message string
    Console.WriteLine("I like cats");
    Console.WriteLine("I like cheese");
    Console.WriteLine("I like sunshine");
  }

  public void TheWeatherMessages()
  {
    Console.WriteLine("It's a beautiful day");
    Console.WriteLine("It's raining");
    Console.WriteLine("It's snowing");
  }

}
