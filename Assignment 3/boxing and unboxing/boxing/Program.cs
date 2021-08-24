class Boxing    // process of converting value type into ref type
{
    static void Main()
    {
        string str="geetika shukla";
        object o = str;//converting a value type into reference type is boxing
        str ="geetu" ;
        System.Console.WriteLine(str);
        System.Console.WriteLine(o);
    }
}
