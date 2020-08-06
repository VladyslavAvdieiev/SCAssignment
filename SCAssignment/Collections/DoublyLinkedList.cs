using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Collections.Test")]
namespace Collections {
    /// <summary>
    /// Represents a doubly linked list.
    /// </summary>
    public class DoublyLinkedList : ILinkedList {
        private int _count;
        private DoublyLinkedListNode _head;
        private DoublyLinkedListNode _tail;

        internal int Count {
            get => _count;
            private set {
                if (value < 0)
                    throw new IndexOutOfRangeException();
                _count = value;
            }
        }

        public void Add(string item) {
            DoublyLinkedListNode node = new DoublyLinkedListNode(item);
            if (_head == null)
                _head = node;
            else {
                _tail.Next = node;
                node.Previous = _tail;
            }
            _tail = node;
            Count++;
        }

        public ILinkedListNode Find(string item) {
            for (DoublyLinkedListNode current = _head; current != null; current = current.Next)
                if (current.Value == item)
                    return current;
            return null;
        }

        public bool Remove(string item) {
            for (DoublyLinkedListNode current = _head; current != null; current = current.Next) {
                if (current.Value == item) {
                    if (current.Previous == null)
                        _head = current.Next;
                    if (current.Next == null) {
                        _tail = current.Previous;
                        _tail.Next = null;
                    }
                    if (current.Previous != null && current.Next != null) {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                    }
                    Count--;
                    return true;
                }
            }
            return false;
        }

        public string[] ToArray() {
            string[] result = new string[Count];
            DoublyLinkedListNode current = _head;
            for (int i = 0; i < Count; i++) {
                result[i] = current.Value;
                current = current.Next;
            }
            return result;
        }
    }
}
