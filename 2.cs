using System;
internal class Program
{
    static void Main(string[] args)
    {
        string s;
        string v, c;
        s = Console.ReadLine();
        s = s.Replace("a", "zcx");
        Console.WriteLine("After:\n" + s);
        s = s.Replace("zcx", "a");
        Console.WriteLine("Before:\n" + s);
    }
}