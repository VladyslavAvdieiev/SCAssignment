using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Collections.Test")]
namespace Collections {
    internal class DoublyLinkedListNode : ILinkedListNode {
        internal DoublyLinkedListNode(string value) { Value = value; }
        internal DoublyLinkedListNode Next { get; set; }
        internal DoublyLinkedListNode Previous { get; set; }
        public string Value { get; }
    }
}
