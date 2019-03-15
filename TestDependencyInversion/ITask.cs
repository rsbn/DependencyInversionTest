namespace TestDependencyInversion
{
    public interface ITask
    {
        string TaskName { get; set; }

        void AsignTo(IPerson person);
        void Execute();
        void Finish();
        void Pause();
    }
}