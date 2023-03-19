using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    class Stack
    {
        public readonly List<string> items = new();
        public int Size => items.Count;
        public string? Top => items.Count <= 0 ? null : items[^1];
        public Stack(params string[] items)
        {
            foreach (var item in items)
            {
                this.items.Add(item);
            }
        }
        public void AddString(string item)
        {
            items.Add(item);
        }
        public string Pop()
        {
            if (items.Count == 0)
            {
                throw new Exception("Stack is empty!");
            }
            string result = items[Size - 1];
            items.Remove(result);
            return result;
        }
        public static Stack Concat(params Stack[] stacks)
        {
            var result = new Stack();

            foreach (var stack in stacks)
            {
                var reversedStack = new Stack(stack.items.ToArray().Reverse().ToArray());
                foreach (var item in reversedStack.items)
                {
                    result.AddString(item);
                }
            }
            return result;
        }
    }
}
