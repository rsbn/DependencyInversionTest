using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDependencyInversion
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static ITask CreateTask()
        {
            return new Task(CreateLogger(), CreateMessenger());
        }
        public static ILogger CreateLogger()
        {
            return new LogToDatabase();
        }
        public static IMessenger CreateMessenger()
        {
            return new Texter();
        }
    }
}
