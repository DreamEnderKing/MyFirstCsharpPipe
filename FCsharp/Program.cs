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
                _writer.Flush();
                _writer.Dispose();
                
            } 
            catch(Exception e){
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("error!\nMessage:{0}", e.Message);
            }
            finally {
                stream.Dispose();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
