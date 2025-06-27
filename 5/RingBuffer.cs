using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5
{
    public class RingBuffer<T>
    {
        private T[] _buffer;
        private int _start;
        private int _end;
        private int _count;

        public RingBuffer(int capacity)
        {
            _buffer = new T[capacity];
        }

        public void Add(T item)
        {
            _buffer[_end] = item;
            _end = (_end + 1) % _buffer.Length;
            if (_count == _buffer.Length)
                _start = (_start + 1) % _buffer.Length;
            else
                _count++;
        }

        public T Remove()
        {
            if (_count == 0) throw new InvalidOperationException("Buffer is empty");
            T item = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            _count--;
            return item;
        }
    }
}