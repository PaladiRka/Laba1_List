using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Laba1_List
{
class List<T> : IEnumerable<T>
    {
        private readonly Node<T> _root;
        private Node<T> _end;
        private int _countNode;
        private IEnumerable<T> _enumerableImplementation;

        public List(Node<T> root)
        {
            _root = root;
            _end = root;
            _countNode = 1;
        }
        
        public int GetCountNode()
        {
            return _countNode;
        }

        public Node<T> GetRoot()
        {
            return _root;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _enumerableImplementation.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            var val = _root;
            while (val != null)
            {
                yield return val;
                if (val.Next == null) yield break;
                val = val.Next;
            }
        }

        public T Pop()
        {
            var node = _end;

            if (ReferenceEquals(_end, _root))
            {
                _end = _root;
                _root.Next = null;
                return node.GetData();
            }

            Node<T> prev = _root;
            while (prev.Next.Next != null)
            {
                prev = prev.Next;
            }

            prev.Next = null;
            --_countNode;
            _end = prev;
            return node.GetData();
        }

        public void Push(Node<T> node)
        {
            if (node != null)
            {
                _end.Next = node;
                node.Next = null;
                _end = node;
                ++_countNode;
            }
        }
        public void Add(T item)
        {
            if (item == null)
            {
                return;
            }
            var node = new Node<T>(item);
            _end.Next = node;
            node.Next = null;
            _end = node;
            ++_countNode;
        }

        public bool Contains(T item)
        {
            if (item == null)
                return false;
            return this.Cast<Node<T>>().Any(node => Equals(node.GetData(), item));
        }

        public bool Contains(Node<T> node)
        {
            if (node == null)
                return false;
            return this.Cast<Node<T>>().Contains(node);
        }
    }
}