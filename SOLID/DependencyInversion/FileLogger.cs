using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class FileLogger : ILogger
    {
        public void LogMessage(string aStackTrace)
        {
            //code to log stack trace into a file.  
        }
    }
}
