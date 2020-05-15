using System;
using System.IO;
using System.Text;

namespace FCsarp
{
    class Program
    {
        static FileStream stream;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try {
                if(!File.Exists("log.txt")) File.Create("log.txt");
                stream = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter _writer = new StreamWriter(stream);
                _writer.WriteLine("hello,world!");
                
            } finally {
                stream.Dispose();
            }
        }
    }
}
