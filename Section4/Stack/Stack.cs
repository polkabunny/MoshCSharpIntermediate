using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack
    {
        private List<object> stack = new List<object>();

        public void Push(object obj)
        {
            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count > 0)
            {
                var returnVal = stack.Last();
                stack.RemoveAt(stack.Count-1);
                return returnVal;
            }
            throw new InvalidOperationException("Cannot pop on empty stack");
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}
