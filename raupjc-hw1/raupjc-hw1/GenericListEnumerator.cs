using System.Collections;
using System.Collections.Generic;

namespace raupjc_hw1
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        private readonly GenericList<T> _genericList;
        private int _currentIndex;

        public GenericListEnumerator(GenericList<T> genericList)
        {
            this._genericList = genericList;

            
        }

        
        public T Current { get; private set; }

        object IEnumerator.Current => _genericList.GetElement(_currentIndex);

        public void Dispose()
        {
            Current = default(T);
        }

        public bool MoveNext()
        {
            if (_currentIndex >= _genericList.Count) return false;
            Current = _genericList.GetElement(_currentIndex);
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = 0;
        }
    }
}