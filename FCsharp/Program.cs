using System;
using System.IO;
using System.Text;

namespace FCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console. WriteLine(TimeSpan.Parse("00:00:01"));
            } 
            catch(Exception e){
                Console. WriteLine(e.Message);
            }
            finally {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
            
        ~Program()
        {
            
        }
    }
}
