using System;
using System.IO;

namespace FCsarp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if(!File.Exists("log.txt")) File.Create("log.txt");
            FileStream stream = new FileStream("log.txt", FileMode.Append, FileAccess.ReadWrite, FileShare.ReadWrite);
            Console.SetOut(new StreamWriter(stream));
            Console.WriteLine("hello world!");
        }
    }
}
