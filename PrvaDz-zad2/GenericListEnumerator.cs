using System;
using System.Collections;
using System.Collections.Generic;

namespace PrvaDz_zad2
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        private int _currentEnumIndex = -1;
        private readonly T[] _internalStorage;
        public GenericListEnumerator(T[] internalStorage)
        {
            this._internalStorage = internalStorage;
        }

        public bool MoveNext()
        {
            _currentEnumIndex++;
            return (_currentEnumIndex < _internalStorage.Length);
        }

        public void Reset()
        {
            _currentEnumIndex = -1;
        }

        public T Current
        {
            get
            {
                try
                {
                    return _internalStorage[_currentEnumIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            return;
        }
    }

}