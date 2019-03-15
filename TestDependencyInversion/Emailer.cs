using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDependencyInversion
{
    public class Emailer : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"EMAILING : { message }");
        }
    }
}
