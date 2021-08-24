using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		
		       //creating a dictionary using collection-initializer syntax
		var employeeList = new Dictionary<string, string>(){
			{"Employee1","Mahesh, 101, Programmer"},
			{"Employee2","Geetika, 102, Washington"},
			{"employee3","Raj, 103, Architect"}
		};
        foreach(var kvp in employeeList)
      		Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

                         // Inserting THE VALUES IN DICTIONARY

        employeeList.Add("Employee4","Prateek,109,Programmer");
        foreach(var kvp in employeeList)
      	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
	       

                         // UPDATING THE VALUES IN DICTIONARY

        employeeList["Employee1"] = "Geetika, 107"; // update value of   Employee1 key
		employeeList["Employee2"] = "Nikhil, 105"; // update value of Employee2 key


		foreach(var kvp in employeeList)
		Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value); 


                           //DELETING AN ELEMENT FROM DICTIONARY

        employeeList.Remove("Employee1"); // removes USA 
		Console.WriteLine("Total Elements: {0}", employeeList.Count);
        foreach(var kvp in employeeList)
        Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

                      
                             //SEARCHING AN ELEMENT IN A DICTIONARY

        var val="Employee2";
            if(employeeList.ContainsKey(val))
            {
            Console.WriteLine(val+ " is found in cities");
            }
	}
    }


