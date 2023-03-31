using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    public class Stack
    {
        private StackItem? top;
        public int Size { get; private set; }
        public Stack(params string[] items)
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }
        public string? Top => top?.Value;
        public void Push(string item)
        {
            top = new StackItem(item, top);
            Size++;
        }
        public string Pop()
        {
            if (top == null)
            {
                throw new StackOverflowException("Stack is empty");
            }
             var item = top.Value;
            top = top.Previous;
            Size--;
             return item;
        }
        public static Stack Concat(params Stack[] stacks)
        {
            var result = new Stack();

            for (int i = 0; i < stacks.Length; i++)
            {
                result.Merge(stacks[i]);
            }
            return result;
        }
    }
}

