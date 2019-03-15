using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = Factory.CreatePerson();
            person.Name = "Dani";
            ITask task = Factory.CreateTask();
            task.TaskName = "Faxina";
            task.AsignTo(person);
            task.Execute();
            task.Pause();
            task.Execute();
            task.Finish();
            Console.ReadLine();
        }
    }
}
