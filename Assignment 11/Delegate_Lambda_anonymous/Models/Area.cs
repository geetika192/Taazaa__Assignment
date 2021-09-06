namespace Delegate_Lambda_anonymous.Models
{
    public class Area
    {
        public double Rectangle(double d1, double d2)
        {
            return d1*d2;
        }
        public void Square(double d)
        {
            System.Console.WriteLine(d*d);
        }
        public double Triangle(double b , double h)
        {
            return (b*h)/2;
        }
    }
}