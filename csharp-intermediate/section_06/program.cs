using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new Workflow();
            workFlow.Add(new VideoUploader());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);
            Console.ReadLine();
        }
    }

    public interface ITask
    {
        void Execute();
    }

    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTask();
    }

    public class Workflow : IWorkflow
    {
        private readonly List<ITask> _List;

        public Workflow()
        {
            _List = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _List.Add(task);
        }

        public void Remove(ITask task)
        {
            _List.Remove(task);
        }

        public IEnumerable<ITask> GetTask()
        {
            return _List;
        }

    }

    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video!");
        }
    }

    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("calling the web services!");
        }
    }

    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email!");
        }
    }

    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("changed status!");
        }
    }

    public class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (ITask task in workflow.GetTask())
                task.Execute();
        }
    }
}
