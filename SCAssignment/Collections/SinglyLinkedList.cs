using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Collections.Test")]
namespace Collections {
    public class SinglyLinkedList : ILinkedList {
        private int _count;
        private SinglyLinkedListNode _head;

        internal int Count {
            get => _count;
            private set {
                if (value < 0)
                    throw new IndexOutOfRangeException();
                _count = value;
            }
        }

        public void Add(string item) {
            if (_head == null)
                _head = new SinglyLinkedListNode(item);
            else {
                SinglyLinkedListNode current = _head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = new SinglyLinkedListNode(item);
            }
            Count++;
        }

        public ILinkedListNode Find(string item) {
            for (SinglyLinkedListNode current = _head; current != null; current = current.Next)
                if (current.Value == item)
                    return current;
            return null;
        }

        public bool Remove(string item) {
            SinglyLinkedListNode current = _head;
            SinglyLinkedListNode previous = null;
            if (current != null && current.Value == item) {
                _head = current.Next;
                Count--;
                return true;
            }
            while (current != null && current.Value != item) {
                previous = current;
                current = current.Next;
            }
            if (current == null)
                return false;
            previous.Next = current.Next;
            Count--;
            return true;
        }

        public string[] ToArray() {
            string[] result = new string[Count];
            SinglyLinkedListNode current = _head;
            for (int i = 0; i < Count; i++) {
                result[i] = current.Value;
                current = current.Next;
            }
            return result;
        }
    }
}
