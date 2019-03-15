using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDependencyInversion
{
    public class LogToDatabase : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"*** Saving log to database : {message}");
        }
    }
}
