using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                Console.WriteLine("You can not add a null object");
            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
            {
                Console.WriteLine("No elements in stack");
            }

            var index = _list.Count - 1;
            var toReturn = _list[index];
            _list.RemoveAt(index);
            return (toReturn);
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
