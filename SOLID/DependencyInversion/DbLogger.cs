﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class DbLogger : ILogger
    {
        public void LogMessage(string aMessage)
        {
            //Code to write message in database.  
        }
    }
}
