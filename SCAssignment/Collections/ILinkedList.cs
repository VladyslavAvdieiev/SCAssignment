namespace Collections {
    public interface ILinkedList {
        void Add(string item);
        ILinkedListNode Find(string item);
        bool Remove(string item);
        string[] ToArray();
    }
}
