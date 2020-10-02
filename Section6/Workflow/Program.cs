using System.Collections.Generic;
using WorkflowEngine.Actions;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow(
                new List<IAction>
                {
                    new UploadAction(),
                    new EncodingNotifyAction(),
                    new ProcessingNotifyAction(),
                    new UpdateDbStatusAction()
                }
            );

            workflow.Run();
        }
    }
}
