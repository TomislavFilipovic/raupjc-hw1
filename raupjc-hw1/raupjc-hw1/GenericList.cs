using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raupjc_hw1
{
    public class GenericList<X> :IGenericList<X>
    {
        private X[] _internalStorage;

        public GenericList() {
            _internalStorage=new X[4];
            Count = 0;
        }
        public GenericList(int initialSize)
        {
            if (initialSize < 0)
            {
                throw new ArgumentOutOfRangeException("Initial size can not be lower than 0");
            }
            _internalStorage = new X[initialSize];
        }
        public void Add(X item)
        {
            if (_internalStorage.Length == Count)
            {
                ExtendArray();
            }
            _internalStorage[Count] = item;
            Count++;
        }
        private void ExtendArray()
        {
            X[] tempArray = new X[_internalStorage.Length * 2];
            Array.Copy(_internalStorage, tempArray, Count);
            _internalStorage = tempArray;
        }
        public bool Remove(X item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            ShiftArray(index);
            Count--;
            return true;
        }
        private void ShiftArray(int from)
        {
            for (int i = from; i < Count; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
        }
        public X GetElement(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return _internalStorage[index];
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Count { get; private set; }
        public void Clear()
        {
            _internalStorage = new X[_internalStorage.Length];
            Count = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}
