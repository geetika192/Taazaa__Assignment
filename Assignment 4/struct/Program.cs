using System;
public struct Person
{
    public string Name;
    public int Age;
    public int Weight;
 
}
class program {
    static void Main(string[] args)
    {
        Person P1=new Person();
        P1.Name = "Geetika shukla";
        P1.Age = 21;
        P1.Weight =50;
        Console.WriteLine("Data Stored in P1 is " + P1.Name + ", age is " +P1.Age + " and weight is " + P1.Weight);
    }
}

