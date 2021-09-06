using System;
using Delegate_Lambda.Models;
delegate string NameDelegate(string str);   //definition of Delegate
delegate int EmpDelegate();

namespace Delegate_Lambda
{
    class Program
    {
        static void Main()
        {

                    //Delegate
           Employee employee =new Employee();
           EmpDelegate empDelegate=new EmpDelegate(employee.emp_ID);
           System.Console.WriteLine(empDelegate.Invoke());
           NameDelegate nameDelegate=new NameDelegate(employee.emp_name);
           System.Console.WriteLine(nameDelegate.Invoke("geetu"));

                     //Func
           Func<string,string> func=employee.emp_name;
           System.Console.WriteLine(func("geetika"));

                  //Action
           Action action= employee.emp_sal;
           action();

                    //Predicate
           Predicate<string> predicate=employee.emp_status;
            System.Console.WriteLine(predicate("Geetu"));
        }
    }
}
