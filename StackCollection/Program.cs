namespace StackCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("a", "b", "c");
            s.Merge(new Stack());

            Console.WriteLine($"size = {s.Size},Top = {s.Top}");
            var deleted = s.Pop();  
           Console.WriteLine($"Took the top element '{deleted}' Size = {s.Size}");
            s.AddString("d");
            Console.WriteLine($"Size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            s.Pop();
            s.Pop();
            Console.WriteLine($"Size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            s.Pop();
            Console.WriteLine("\n");
            s = Stack.Concat(new Stack("a","b","c"), new Stack("1","2","3"), new Stack("A","Б","B"));
            Console.WriteLine($"Size = {s.Size}, Top = '{s.Top}'");

        }
    }
    class Stack
    {
        private readonly List<string> items = new();
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
            string result = items[^1];
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


