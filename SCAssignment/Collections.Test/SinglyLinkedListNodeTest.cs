using Xunit;

namespace Collections.Test {
    public class SinglyLinkedListNodeTest {
        [Theory]
        [InlineData(null)]
        [InlineData("item1")]
        public void Should_InitializeProperties(string expectedItem) {
            SinglyLinkedListNode actualNode = new SinglyLinkedListNode(expectedItem);
            SinglyLinkedListNode expectedNode = new SinglyLinkedListNode(expectedItem);
            actualNode.Next = expectedNode;

            Assert.Equal(expectedItem, actualNode.Value);
            Assert.Equal(expectedNode, actualNode.Next);
        }
    }
}
