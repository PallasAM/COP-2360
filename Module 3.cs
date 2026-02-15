using System;

public class Octopus
{
    public string Name {get; set; }
    public int Age { get; set; }
    public readonly int Legs;

    //Constructor
    public Octopus(string name, int age, int legs)
  {
    
      Name = name;
      Age = age;
      Legs = legs;
  }
  
  public void DisplayInfo()
  {
    Console.WriteLine($"Octopus Name: {Name}, Age: {Age}, Legs: {Legs}");
  }
}

class Program
{
  static void Main()
  {
      //class creation
      Octopus Reginald = new Octopus("Reginald", 7, 8);
      Reginald.DisplayInfo();
  }         }