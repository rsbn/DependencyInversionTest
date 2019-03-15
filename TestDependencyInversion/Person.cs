using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDependencyInversion
{
    public class Person : IPerson
    {
        public string Name { get; set; }
    }
}
