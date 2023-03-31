
using System.Collections;
using System.Drawing;

namespace StackCollection
{
    static class MyStackExtension
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            while (s2.Size > 0)
            {
                s1.Push(s2.Pop());
            }
        }
    }
}
