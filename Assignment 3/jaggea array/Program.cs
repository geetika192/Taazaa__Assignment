public class JaggedArray  
{  
    public static void Main()  
    {  
        int[][] arr = new int[2][];// Declare the array  
  
        arr[0] = new int[] { 10, 20, 30, 40 };// Initialize the array          
        arr[1] = new int[] { 11, 22, 33, 44, 55, 66 };  
  
        // Traverse array elements  
        for (int i = 0; i < arr.Length; i++)  
        {  
            for (int j = 0; j < arr[i].Length; j++)  
            {  
                System.Console.Write(arr[i][j]+" ");  
            }  
            System.Console.WriteLine();  
        }  
    }  
}
