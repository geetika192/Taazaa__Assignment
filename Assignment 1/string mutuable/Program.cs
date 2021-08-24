using System;
using System.Text;

public class Program {
   public static void Main() {
      StringBuilder str = new StringBuilder("hlo World",30);
      str.Replace("World", "India");

      Console.WriteLine(str);
   }
}
