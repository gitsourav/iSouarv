using iSourav.Domain.Interfaces.Providers;
using System;
using System.Diagnostics;

using System.IO;

namespace iSourav.DebugLogger
{
    public class Debug : ILoggerProvider
    {
        public void Error(string message)
        {
            System.Diagnostics.Debug.WriteLine("ERROR:  " + message);
        }

        public void Error(string format, params object[] args)
        {
            System.Diagnostics.Debug.WriteLine("ERROR:  " + format, args);
        }

        public void Error(Exception ex, string message)
        {
            System.Diagnostics.Debug.WriteLine("ERROR:  " + message);
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        public void Error(Exception ex, string format, params object[] args)
        {
            System.Diagnostics.Debug.WriteLine("ERROR:  " + format, args);
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        public void Info(string message)
        {
            System.Diagnostics.Debug.WriteLine("INFO:  " + message);
        }

        public void Info(string format, params object[] args)
        {
            System.Diagnostics.Debug.WriteLine("INFO:  " + format, args);
        }

        public void Info(Exception ex, string message)
        {
            System.Diagnostics.Debug.WriteLine("INFO:  " + message);
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        public void Info(Exception ex, string format, params object[] args)
        {
            System.Diagnostics.Debug.WriteLine("INFO:  " + format, args);
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }
    }
}
