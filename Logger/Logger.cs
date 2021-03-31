using System;
using System.IO;
using System.Collection.Generics;

namespace Logger
{
    class Dispose: IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Console.Beep();
        }
        // protected virtual void Dispose(bool dispo)
        // {
        //     if(!disposed)
        //     {
        //         if(disposing)
        //         {

        //         }
        //     }
        // }
    }
    ////////////////////////////////////////////////
    class Logger: Dispose, ILog
    {
        Dispose dispo = null;
        List<string> erUn = new List<string>();
        List<string> warUn = new List<string>();
        //заимств
         private const string fileExt = ".log";

        private static string dirPath;
        private string fatalErrorPath;
        private string errorPath;
        private string errorUniquePath;
        private string warningPath;
        private string warningUniquePath;
        private string infoPath;
        private string debugPath;
        private string systemInfoPath;

        private const string fatalName = "Fatal";
        private const string errorName = "Error";
        private const string errorUniqueName = "ErrorUnique";
        private const string warningName = "Warning";
        private const string warningUniqueName = "Warning Unique";
        private const string infoName = "Info";
        private const string debugName = "Debug";
        private const string systemInfoName = "SystemInfo";
        //
        //реализация 2 интерфейса
        
        //static методы  говнокод получайте на на на
        public static void Write(sting path, string name, string message)
        {
            try
            {
                Dispose instance = new Dispose();
                StreamWriter sw = new StreamWriter(path,true,System.Text.Encoding,Default);
                sw.WriteLine(name + " " + DateTime.Now + "  " + message)

            }
            catch (Exception exception)
            {
                System.Console.WriteLine(ex);
            }
            finally
            {
                instance.Dispose()
            }
        }
        public static void Write(string path, string name, string message, Exception exception)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path,true, System.Text.Endcoding.Default);
                Dispose instance = new Dispose();
                sw.WriteLine(name +" " + DateTime.Now +" "+message + exception);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            finally
            {
                instance.Dispose()
            }
        }
        public static void Write(string path, string name, string message, params object[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path,true, System.Text.Endcoding.Default);
                Dispose instance = new Dispose();
                sw.WriteLine(name +" " + DateTime.Now +" "+message + argv);
                for (int i = 0; i < args.Lenght; i++)
                {
                   argv += args[i] 
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            finally
            {
                instance.Dispose()
            }
        }
        public static void Write(string path, string name, Exception exception)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path,true, System.Text.Endcoding.Default);
                Dispose instance = new Dispose();
                sw.WriteLine(name +" " + DateTime.Now +" "+ exception);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            finally
            {
                instance.Dispose()
            }
        }
        public static void Write(string writePath, string logName, string message, Dictionary<object, object> properties = null)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(writePath,true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(logName + ". New Dictionary: " + " | " + DateTime.Now);
                    foreach(KeyValuePair<object, object> p in properties)
                    {
                        sw.WriteLine("{0}: {1}", p.Key.ToString(), p.Value.ToString());
                    }
                    sw.WriteLine("End of dictionary." );
                    sw.WriteLine();
                }
                if (isConsoleEnabled)
                    Console.WriteLine(logName + " added to log " + writePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //
        private static void Check_mkdir_exist()
        {
            if(!Directory.Exists(@"")
            {
                Directory.CreateDirectory(@"");
                erUn.Clear();
                warUn.Clear();
            }
        }
        private void file_check()
        {
            if(File.Exists(dirPath))
            {
                Directory.CreateDirectory(@"");
                erUn.Clear();
                warUn.Clear();
            }
            if(File.Exists(warningPath))
            {
                Directory.CreateDirectory(@"");
                erUn.Clear();
                warUn.Clear();
            }
            if(File.Exists(errorUniquePath))
            {
                Directory.CreateDirectory(@"");
                erUn.Clear();
                warUn.Clear();
            }
            if(File.Exists(errorPath))
            {
                Directory.CreateDirectory(@"");
                erUn.Clear();
                warUn.Clear();
            }
        }
        private void Paths()
        {
            fatalErrorPath = dirPath + @"\" + fatalName + fileExt;
            errorPath = dirPath + @"\" + errorName + fileExt;
            errorUniquePath = dirPath + @"\" + errorUniqueName + fileExt;
            warningPath = dirPath + @"\" + warningName + fileExt;
            warningUniquePath = dirPath + @"\" + warningUniqueName + fileExt;
            infoPath = dirPath + @"\" + infoName + fileExt;
            debugPath = dirPath + @"\" + debugName + fileExt;
            systemInfoPath = dirPath + @"\" + systemInfoName + fileExt;
        }
        private static bool isContains(string message, List<string> notUniqueElemList,  string e = "__*unique*__")
        {
            foreach(string str in notUniqueElemList)
            {
                if(str.Contains(message) || str.Contains(e))
                    return true;
            }   
            return false;
        }
        public void Fatal(string message)
        {
            Logger.Write(fatalErrorPath, fatalName, message);
        }
        public void Fatal(string message, Exception e)
        {
            Logger.Write(fatalErrorPath, fatalName, message, e);
        }
        public void Error(string message)
        {
            Logger.Write(errorPath, errorName, message);
            warUN.Add(message);
        }
        public void Error(Exception e)
        {
            Logger.Write(errorPath, errorName, e);
            warUN.Add(e.ToString());
        }
        public void Error(string message, Exception e)
        {
            Logger.Write(errorPath, errorName, message, e);
            warUN.Add(message);
            warUN.Add(e.ToString());
        } 
        public void ErrorUnique(string message, Exception e)
        {
            if(!isContains(message, warUN, e.ToString()))
            {
                warUN.Add(message);
                warUN.Add(e.ToString());
                Logger.Write(errorUniquePath, errorUniqueName, message, e);
            }  
        }
        public void Warning(string message)
        {
            Logger.Write(warningPath, warningName, message);
            warUN.Add(message);
        }
        public void Warning(string message, Exception e)
        {
            Logger.Write(warningPath, warningName, message, e);
            warUN.Add(message);
        }
        public void WarningUnique(string message)
        {
            if(!isContains(message, warUN))
            {
                warUN.Add(message);
                Logger.Write(warningUniquePath, warningUniqueName, message);
            }
        }
        public void Info(string message)
        {
            Logger.Write(infoPath, infoName, message);
        }
        public void Info(string message, Exception e)
        {
            Logger.Write(infoPath, infoName, message, e);
        }
        public void Info(string message, params object[] args)
        {
            Logger.Write(infoPath, infoName, message, args);
        }
        public void Debug(string message)
        {
            Logger.Write(debugPath, debugName, message);
        }
        public void Debug(string message, Exception e)
        {
            Logger.Write(debugPath, debugName, message, e);
        }
        public void DebugFormat(string message, params object[] args)
        {
            Logger.Write(debugPath, debugName, message, args);
        }
        public void SystemInfo(string message, Dictionary<object, object> properties = null)
        {
            Logger.Write(systemInfoPath, systemInfoName, message, properties);
        }
    }
}