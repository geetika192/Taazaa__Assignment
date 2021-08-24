using System; 
class foreachloop 
{ 
    public static void Main() 

    { 
        Console.WriteLine("required number"); 
        int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 }; 
        foreach(int items in a_array) 

        { 
            Console.WriteLine(items); 
        } 
    } 
}