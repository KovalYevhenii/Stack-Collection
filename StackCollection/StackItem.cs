using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    public class StackItem
    {
        public string? Value { get; set; }
           
        public StackItem? Previous { get; set; }
        public StackItem(string? value, StackItem previous)
        {
            Value = value;
            Previous = previous;
        }
    
    }
}
