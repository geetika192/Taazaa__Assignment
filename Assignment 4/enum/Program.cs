using System;
namespace MyApplication
{
  class Program   
  {
    enum Months   //An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
    {
      January,    
      February,   
      March,      
      April,      
      May,        
      June,       
      July        
    }
    static void Main(string[] args)
    {
      int myNum = (int) Months.April;  //You can access enum items with the dot syntax
      Console.WriteLine(myNum);  //To get the integer value from an item, you must explicitly convert the item to an int
    }
  }
}