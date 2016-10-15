using System;
using System.Threading;

namespace PrvaDz
{
    public class IntegerList : IIntegerList
    {
        private const int NoItem = -1;
        private int[] _internalStorage;
        private int _maxSize;
        private int _currentSize = 0;

        public IntegerList()
        {
            _internalStorage = new int[4];
            _maxSize = 4;
        }

        public IntegerList(int initialSize)
        {
            if (initialSize < 0) initialSize = Math.Abs(initialSize);
            _internalStorage = new int[initialSize];
            _maxSize = initialSize;
        }

        public void Add(int item)
        {
            if (_currentSize == _maxSize - 1)
            {
                var tempStorage = new int[_maxSize*2];
                _maxSize = _maxSize*2;
                for (int i = 0; i < _currentSize; i++)
                {
                    tempStorage[i] = _internalStorage[i];
                }
                _internalStorage = tempStorage;
            }
            _internalStorage[_currentSize++] = item;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < _currentSize; i++)
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
            if (index >= _currentSize) return false;
            for (int i = index; i < _currentSize-1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _currentSize--;
            return true;
        }

        public int GetElement(int index)
        {
            if (index < _currentSize)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }
            return NoItem;
        }

        public int Count
        {
            get { return _currentSize; }
        }

        public void Clear()
        {
            _currentSize = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}