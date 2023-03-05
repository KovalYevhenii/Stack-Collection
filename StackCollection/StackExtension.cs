using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    static class MyStackExtension
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            var temp = new Stack("1", "2", "3");
            while (s2.Size > 0)
            {
                temp.AddString(s2.Pop());
            }
            while (temp.Size > 0)
            {
                s1.AddString(temp.Pop());
            }
        }
    }
}
