using System;
using Delegate_Lambda_anonymous.Models;
delegate double AreaDelegate(double d1, double d2);
delegate void ArDelegate(double d1, double d2);
delegate void ADelegate(double d);
namespace Delegate_Lambda_anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
           Area area=new Area();
            // using Delegate
           AreaDelegate areaDelegate=new AreaDelegate(area.Rectangle);
           System.Console.WriteLine(areaDelegate(5,10));
          /*  areaDelegate+=area.Square;
           var temp=areaDelegate(12);
           System.Console.WriteLine(temp); */

                  //using anonymous Function
            ArDelegate ar=delegate(double d1,double d2)
            {
                Console.WriteLine((d1*d2)/2);
            };
            ar(10,20);
                
                 //using Lambda Function

            ADelegate ar1=(double d) =>
            {
                System.Console.WriteLine(d*d);
            };
            ar1(5);
        }
    }
}
