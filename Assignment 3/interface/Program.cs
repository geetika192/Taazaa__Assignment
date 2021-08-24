using System;  
public interface Drawable  
{  
    abstract void draw();  
}  
public class Rectangle : Drawable  
{  
    public  void draw()  
    {  
        Console.WriteLine("drawing rectangle");  
    }  
}  
public class Circle : Drawable  
{  
    public  void draw()  
    {  
        Console.WriteLine("drawing circle");  
    }  
}  
public class TestInterface  
{  
    public static void Main()  
    {  
        Rectangle d = new Rectangle();   
         d.draw();  
        Circle d1 = new Circle();  
         d1.draw();  
    }  
}  
