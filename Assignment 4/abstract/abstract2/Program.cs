using System;
    public abstract class math
    {
        public void geometry()
        {
            Console.WriteLine("draw a line");
        }
      public abstract void sum();
    }
    public class arithmetic:math
    {
        public override void sum()
        {
          Console.WriteLine("4");  
        }
        public static void Main()
        {
            var obj= new arithmetic();
            obj.geometry();
            obj.sum();
        }
    } 

