using System;
abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  public void sleep()
  {
    Console.WriteLine("sleeping");
  }
}
class horse : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("horse class function");
  }
}

class Program
{
  static void Main(string[] args)
  {
    horse h1 = new horse(); 
    h1.animalSound();  
    h1.sleep();  
  }
}
