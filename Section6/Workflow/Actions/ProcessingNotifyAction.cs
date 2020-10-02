using System;

namespace WorkflowEngine.Actions
{
    public class ProcessingNotifyAction : IAction
    {
        public void Execute()
        {
            Console.WriteLine("Processing has begun, email sent");
        }
    }
}
