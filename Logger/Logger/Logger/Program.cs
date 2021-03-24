﻿using System;
using System.IO;

namespace Logger
{
    public abstract class LogBase
    { 
            public abstract void Log(string Messsage);
    }

    public class Logger: LogBase
    {

        public string directory_path = @"home/perdomix/RiderProjects/Bars_Group/Logger";
        private String CurrentDirectory
        {
            get;
            set;
        }

        private String FileName{
            get;
            set;
        }

        private String FilePath {
            get;
            set;
        }

        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + "/"  + this.FileName;
        
        }

        public override void Log(string Messsage)
        {
           
            System.Console.WriteLine("Logged : {0}", Messsage);

            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.FilePath))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("  :{0}", Messsage);
                w.WriteLine("-----------------------------------------------");
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
          
            var logger = new Logger();
            logger.Log("Soumil Nitin Shah");

        }
    }
}
