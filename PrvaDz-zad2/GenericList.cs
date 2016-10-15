using System;
using System.Collections;
using System.Collections.Generic;

namespace PrvaDz_zad2
{
    public class GenericList<T> : IGenericList<T>
    {
        private T[] _internalStorage;
        private const int NoItem = -1;
        private int _maxSize;
        private int _currentSize = 0;

        public GenericList()
        {
            _internalStorage = new T[4];
            _maxSize = 4;
        }

        public GenericList(int size)
        {
            if (size < 0) size = Math.Abs(size);
            _internalStorage = new T[size];
            _maxSize = size;
        }

        public void Add(T item)
        {
            if (_currentSize == _maxSize - 1)
            {
                var tempStorage = new T[_maxSize*2];
                _maxSize = _maxSize*2;
                for (int i = 0; i < _currentSize; i++)
                {
                    tempStorage[i] = _internalStorage[i];
                }
                _internalStorage = tempStorage;
            }
            _internalStorage[_currentSize++] = item;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < _currentSize; i++)
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
            if (index >= _currentSize) return false;
            for (int i = index; i < _currentSize - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _currentSize--;
            return true;
        }

        public T GetElement(int index)
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

        public int IndexOf(T item)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i].Equals(item))
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

        public bool Contains(T item)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new GenericListEnumerator<T>(_internalStorage);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
