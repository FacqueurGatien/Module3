using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAtome
{
    public class ConcreteIterator<T, T2> : Iiterator<T,T2> where T2 : T where T : class
    {
        private int position;
        private IList<T> elements;
        public ConcreteIterator(IList<T> elements)
        {
            position = -1;
            this.elements = elements;
        }
        public T2 GetNext()
        {
            T2 element = default;
            while (position < elements.Count -1 || elements[position+1] is not T2 )
            {
                position++;

                if (elements[position] is T2)
                {
                    return (T2)elements[position];
                }
            }
            return element;
        }

        public bool HasNext()
        {
            bool test = false;
            int tempPos = position;
            while (tempPos< elements.Count -1 && !test)
            {
                test = elements[++tempPos] is T2;
            }
            return test;
        }
    }
}
