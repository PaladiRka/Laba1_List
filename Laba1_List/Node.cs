using System;
using System.Collections.Generic;

namespace Laba1_List
{
    class Node<T>
    {
        private readonly T _data;
        public Node<T> Next;

        public Node(T data)
        {
            _data = data;
            this.Next = null;
        }

        public T GetData()
        {
            return _data;
        }

        public override bool Equals(object val)
        {
            if (val == null) return this.Equals(null);
            if (!(val is Node<T> m))
                return false;
            return Equals(m.GetData(), this.GetData());
        }

        private bool Equals(Node<T> other)
        {
            return EqualityComparer<T>.Default.Equals(_data, other._data);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_data);
        }
    }
}