using System;
using System.Collections;
	
public class Program
{
	public static void Main()
	{
		//creating a dictionary using collection-initializer syntax
		var cities = new Hashtable(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};

		foreach(DictionaryEntry kvp in cities)
		Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


        string citiesOfUK = (string) cities["UK"]; //cast to string
		string citiesOfUSA = (string) cities["USA"]; //cast to string

		Console.WriteLine(citiesOfUK);
		Console.WriteLine(citiesOfUSA);

        cities.Add("Australia","Australia");
        foreach(DictionaryEntry kvp in cities)
      	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
              
              //UPDATE OPERATION IN A HASH TABLE

		cities["UK"] = "Liverpool, Bristol"; // update value of UK key
		cities["USA"] = "Los Angeles, Boston"; // update value of USA key	
		Console.WriteLine("---After updating values---");
		
		foreach(DictionaryEntry de in cities)
			Console.WriteLine("key: {0}, Value: {1}", de.Key, de.Value);
                 
                   //DELETE OPERATION IN HASH TABLE

        cities.Remove("UK"); // removes UK 
		

		Console.WriteLine("Total Elements: {0}", cities.Count);
		
		if(cities.ContainsKey("France")){ // check key before removing it
			cities.Remove("France");
		}

                     //SEARCH OPERATION IN HASH TABLE

        var val="India";
        if(cities.ContainsKey(val))
        {
          Console.WriteLine(val+"is found in cities");
        } 	
	}
}


