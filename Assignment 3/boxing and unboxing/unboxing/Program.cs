class Unboxing //process of converting ref type to value type
{
    static void Main()
    {
        int i = 8765; 
        object o = i;//converting a value type into reference type is boxing
        int j=(int)o;// Unboxing by casting
        System.Console.WriteLine( i);
        System.Console.WriteLine( j);
    }
}
