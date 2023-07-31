using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAtome
{
    public interface Icolection<T>:IList<T>
    {
        public Iiterator<T, T2> GetIterator<T, T2>() where T2 : T where T : class;
    }
}
