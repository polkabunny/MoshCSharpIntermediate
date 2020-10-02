using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow
    {
        private readonly List<IAction> _actions;

        public Workflow(List<IAction> actions)
        {
            _actions = actions;
        }

        public void Run()
        {
            foreach (var action in _actions)
            {
                action.Execute();
            }
        }
    }
}
