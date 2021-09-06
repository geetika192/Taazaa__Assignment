namespace Delegate_Lambda.Models
{
    public class Employee
    {
      public int emp_ID()
      {
         return 123;
      } 
      public void emp_sal()
      {
          System.Console.WriteLine(20000);
      }
      public string emp_name(string nm)
      {
          return nm;
      }

      public bool emp_status(string k)
      {
          return true;

      }
    }
}