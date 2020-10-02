using System;

namespace WorkflowEngine.Actions
{
    public class EncodingNotifyAction : IAction
    {
        public void Execute()
        {
            Console.WriteLine("Encoding service called, video is ready");
        }
    }
}
