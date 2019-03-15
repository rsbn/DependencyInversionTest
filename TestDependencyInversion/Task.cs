using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDependencyInversion
{
    public class Task : ITask
    {
        IPerson _person;
        ILogger _logger;
        IMessenger _messenger;

        public string TaskName { get; set; }
        public Task(ILogger logger, IMessenger messenger)
        {
            _logger = logger;
            _messenger = messenger;
        }
        public void AsignTo(IPerson person)
        {
            _person = person;
            _logger.Log($"Task { TaskName } asigned to {_person.Name }");

        }
        public void Execute()
        {
            Console.WriteLine($"{ _person.Name } Doing { TaskName }>>>");
            _logger.Log($"Task { TaskName } being done by { _person.Name }");
        }
        public void Pause()
        {
            Console.WriteLine($"{ _person.Name } pausing { TaskName }...");
            _logger.Log($"Task { TaskName } PAUSED by { _person.Name }");
        }
        public void Finish()
        {
            Console.WriteLine($"{ _person.Name } finished { TaskName }!!!");
            _logger.Log($"Task { TaskName } FINISHED by { _person.Name }. Congratulations!");
            _messenger.SendMessage($"Hi {_person.Name } congratulations on finishind the task {TaskName }");
        }
    }
}
