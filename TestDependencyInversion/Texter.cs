using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDependencyInversion
{
    public class Texter : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"TEXTING : { message }");
        }
    }
}
