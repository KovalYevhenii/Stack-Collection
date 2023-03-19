using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace StackCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("a", "b", "c");
            s.Merge(new Stack("1","2","3"));
           
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
   
}


