using System;
namespace StringApplication
{
class StringProg
{
static void Main(string[] args)
{
string str1 = "taaza";
string str2 = "company";
if (String.Compare(str1, str2) == 0)
{
Console.WriteLine(str1 + " and " + str2 + " are equal.");
}
else
{
Console.WriteLine(str1 + " and " + str2 + " are not equal.");
}
Console.ReadKey() ;
}
}
}
