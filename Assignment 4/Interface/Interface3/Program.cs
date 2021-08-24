using System;

namespace Interface3
{
    public interface restraunt
    {
        public void closing_time();  //declaration
    }

    public class order:restraunt
    {
       public void closing_time()  //implementation
       {
           Console.WriteLine("closing time is 10pm");
       }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            restraunt obj=new order();
            obj.closing_time();
        }
    }
}
