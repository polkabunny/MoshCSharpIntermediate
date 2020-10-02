using System;

namespace WorkflowEngine.Actions
{
    public class UpdateDbStatusAction : IAction
    {
        public void Execute()
        {
            Console.WriteLine("Db status updated to \"Processing\"");
        }
    }
}
