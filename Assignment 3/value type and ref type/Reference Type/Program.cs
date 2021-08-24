using System;

public class Student{

	public string StudentName { get; set; }
	
}
public class Program
{
	public static void ChangeReferenceType(Student std2)
	{
		std2.StudentName   = "Geetika";
	}
	
	public static void Main()
	{
		Student std1 = new Student();
		
		std1.StudentName = "Shukla";
		
		ChangeReferenceType(std1);
	
		Console.WriteLine(std1.StudentName);
	}
}
