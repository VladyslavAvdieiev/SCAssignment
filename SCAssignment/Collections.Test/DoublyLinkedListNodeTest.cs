using Xunit;

namespace Collections.Test {
    public class DoublyLinkedListNodeTest {
        [Theory]
        [InlineData(null)]
        [InlineData("item1")]
        public void Should_InitializeProperties(string expectedItem) {
            DoublyLinkedListNode actualNode = new DoublyLinkedListNode(expectedItem);
            DoublyLinkedListNode expectedNode = new DoublyLinkedListNode(expectedItem);
            actualNode.Next = expectedNode;
            actualNode.Previous = expectedNode;

            Assert.Equal(expectedItem, actualNode.Value);
            Assert.Equal(expectedNode, actualNode.Next);
            Assert.Equal(expectedNode, actualNode.Previous);
        }
    }
}
