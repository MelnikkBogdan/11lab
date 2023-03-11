using System;
internal class Program
{
    static void Main(string[] args)
    {
        string name, last,father;
        name=Console.ReadLine();
        last=Console.ReadLine();
        father=Console.ReadLine();
        int n=name.Length,l=last.Length,f=father.Length;
        last = last.Replace("a", "");
        last = last.Replace("o", "");
        Console.Write(name+" "+last+" "+father);
    }
}