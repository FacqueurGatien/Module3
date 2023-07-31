using ComposititeAtome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAtome
{
    public class ConcreteCollection<T> : Icolection<T>
    {
        private readonly IList<T> colection;
        public ConcreteCollection() 
        {
            colection = new List<T>();
        }
        public T this[int index] { get => colection[index]; set => throw new NotImplementedException(); }

        public int Count => colection.Count;

        public bool IsReadOnly =>true;

        public void Add(T item)
        {
            colection.Add(item);
        }

        public void Clear()
        {
            colection.Clear();
        }

        public bool Contains(T item)
        {
            return colection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            return;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Iiterator<T,T2> GetIterator<T,T2>() where T2 : T where T : class
        {
            return new ConcreteIterator<T,T2>((List<T>)colection);
        }

        public int IndexOf(T item)
        {
            return 0;
        }

        public void Insert(int index, T item)
        {
            return;
        }

        public bool Remove(T item)
        {
            return colection.Remove(item);
        }

        public void RemoveAt(int index)
        {
            return;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
