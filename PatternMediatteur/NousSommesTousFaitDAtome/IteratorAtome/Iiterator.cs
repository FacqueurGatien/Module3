using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAtome
{
    public interface Iiterator<T, T2> 
    {
        public T2 GetNext();
        public bool HasNext();
    }
}
