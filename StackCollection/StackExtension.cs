
using System.Collections.Generic;
namespace StackCollection
{
    static class MyStackExtension
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            var temp = new List<string>(s2.items);
            temp.Reverse();

            foreach (var item in temp)
            {
                s1.items.Add(item);
            }
          
        }
    }
}
