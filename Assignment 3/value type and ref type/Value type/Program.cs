using System;
					
public class Program
{
	static void ChangeValue(int x)
	{
		x =  500;
	
		Console.WriteLine(x);
	}
	
	public static void Main()
	{
		 int i = 999;

		Console.WriteLine(i);
		
		ChangeValue(i);
		
		Console.WriteLine(i);
	}
}