using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Collections.Test")]
namespace Collections {
    internal class SinglyLinkedListNode : ILinkedListNode {
        internal SinglyLinkedListNode(string value) { Value = value; }
        internal SinglyLinkedListNode Next { get; set; }
        public string Value { get; }
    }
}
