namespace Collections {
    /// <summary>
    /// Represents a linked list.
    /// </summary>
    public interface ILinkedList {
        /// <summary>
        /// Adds an item to the <see cref="Collections.ILinkedList"/>.
        /// </summary>
        /// <param name="item">The string to add to the <see cref="Collections.ILinkedList"/>.</param>
        void Add(string item);
        /// <summary>
        /// Finds the first node that contains the specified value.
        /// </summary>
        /// <param name="item">The string to locate in the <see cref="Collections.ILinkedList"/>.</param>
        /// <returns>The first <see cref="Collections.ILinkedListNode"/> that contains the specified string, if found; otherwise, null.</returns>
        ILinkedListNode Find(string item);
        /// <summary>
        /// Removes the first occurrence of a specific string from the <see cref="Collections.ILinkedList"/>.
        /// </summary>
        /// <param name="item">The string to remove from the <see cref="Collections.ILinkedList"/>.</param>
        /// <returns>true if item was successfully removed from the <see cref="Collections.ILinkedList"/>; otherwise, false.</returns>
        bool Remove(string item);
        /// <summary>
        /// Copies the elements of the <see cref="Collections.ILinkedList"/> to a new array.
        /// </summary>
        /// <returns>An array containing copies of the elements of the <see cref="Collections.ILinkedList"/>.</returns>
        string[] ToArray();
    }
}
