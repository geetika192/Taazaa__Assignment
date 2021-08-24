using System;

namespace Interface
{
    class Program
    {
      public interface Drawable  
{  
    void draw();  
}  
public class Rectangle : Drawable  
{  
    public void draw()  
    {  
        Console.WriteLine("rectangle");  
    }  
}  
public class Circle : Drawable  
{  
    public void draw()  
    {  
        Console.WriteLine(" circle");  
    }  
}  
public class TestInterface  
{  
    public static void Main()  
    {  
        Drawable d;  
        d = new Rectangle();  
        d.draw();  
        d = new Circle();  
        d.draw();  
    }  
}  
    }
}
