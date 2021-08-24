using System;
namespace StringApplication {
   class StringProg {
      static void Main(string[] args) {
         string str1 = "geetika";
         string str2 = "shukla";

         if (String.Compare(str1, str2) == 0) {
            Console.WriteLine(str1 + " and " + str2 + " are equal strings.");
         } else {
            Console.WriteLine(str1 + " and " + str2 + " are not equal strings.");
         }
         Console.ReadKey() ;
      }
   }
}
