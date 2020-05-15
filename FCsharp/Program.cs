using System;
using System.IO;
using System.Text;

namespace FCsharp
{
    public enum loggerType
    {
        ErrorMsg,
        WarningMsg,
        InfoMsg
    }
    class logger
    {
        public logger(string filepath)
        {
            if(!File.Exists("log.txt")) File.Create("log.txt");
            _stream = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            _writer = new StreamWriter(_stream);
            
        }
        private Stream _stream;
        private StreamWriter _writer;
        public void Write(object o,loggerType lt)
        {
            switch (lt) {
                case loggerType.ErrorMsg:
                    _writer.WriteLine("[Error:{0}]", DateTime.Now.ToString());
                    break;
                case loggerType.WarningMsg:
                    _writer.WriteLine("[Warning:{0}]", DateTime.Now.ToString());
                    break;
                case loggerType.InfoMsg:
                    _writer.WriteLine("[Information:{0}]", DateTime.Now.ToString());
                    break;
                default:
                    throw new Exception("Invalid value for loggerType");
            }
            _writer.WriteLine(o);
            _writer.Flush();
        }
        public void Write(object o)
        {
            Write(o, loggerType.InfoMsg);
        }
        public void Dispose()
        {
            _writer.Dispose();
            _stream.Dispose();
        }
    }
    
    class Program
    {
        public static logger log = new logger("log.txt");
        static void Main(string[] args)
        {
            try {
                log.Write("info msg!");
                log.Write("warning msg!",loggerType.WarningMsg);
                //zero divided
                int c = 24 - 4 * 6;
                int i = 12 / c;
            } 
            catch(Exception e){
                log.Write(e.Message, loggerType.ErrorMsg);
            }
            finally {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
            
        ~Program()
        {
            log.Dispose();
        }
    }
}
