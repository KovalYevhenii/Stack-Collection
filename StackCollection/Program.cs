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
         var stack = new Stack("a","b","c");
          stack.Merge(new Stack("1", "2", "3"));
            Console.WriteLine($"size = {stack.Size},Top = {stack.Top}");

            var s = Stack.Concat(new Stack("a","b","c"), new Stack("1", "2", "3"), new Stack("A", "Б", "В"));
            Console.WriteLine($"size = {s.Size},Top = {s.Top}");
        }
    }
}


