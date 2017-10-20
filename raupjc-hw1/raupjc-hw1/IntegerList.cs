using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raupjc_hw1
{
    public class IntegerList:IIntegerList
    {
        private int[] _internalStorage;

        public IntegerList()
        {
            _internalStorage=new int[4];
            Count = 0;
        }

        public IntegerList(int initialSize)
        {
            if (initialSize < 0)
            {  
                throw new ArgumentOutOfRangeException("Initial size can not be lower than 0");
            }
            _internalStorage=new int[initialSize];
        }

        public int Count { get; private set; }

        public void Add(int item)
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
            int [] tempArray=new int[_internalStorage.Length*2];
            Array.Copy(_internalStorage,tempArray,Count);
            _internalStorage = tempArray;
        }

        public void Clear()
        {
            _internalStorage=new int[_internalStorage.Length];
            Count = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetElement(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return _internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >=Count)
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
    }
   
}
