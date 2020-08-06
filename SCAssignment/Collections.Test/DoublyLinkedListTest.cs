using System.Collections.Generic;
using Xunit;

namespace Collections.Test {
    public class DoublyLinkedListTest {
        private readonly DoublyLinkedList linkedList;

        public DoublyLinkedListTest() {
            linkedList = new DoublyLinkedList();
        }

        [Fact]
        public void AddValueToList_Should_IncreaseCount() {
            string[] sourceItems = new string[] { "item1", "item2", "item3" };

            foreach (string item in sourceItems)
                linkedList.Add(item);

            Assert.Equal(sourceItems.Length, linkedList.Count);
        }

        [Fact]
        public void RemoveValueFromList_Should_DecreaseCount() {
            string[] sourceItems = new string[] { "item1", "item2", "item3" };

            foreach (string item in sourceItems)
                linkedList.Add(item);
            linkedList.Remove("item1");

            Assert.Equal(sourceItems.Length - 1, linkedList.Count);
        }

        [Theory]
        [MemberData(nameof(Add_GetItems))]
        public void Add_Should_AddValueToList(string[] sourceItems) {
            foreach (string item in sourceItems)
                linkedList.Add(item);

            string[] actualItems = linkedList.ToArray();
            Assert.Equal(sourceItems, actualItems);
        }

        public static IEnumerable<object[]> Add_GetItems() {
            yield return new object[] { new string[] { } };
            yield return new object[] { new string[] { "item1" } };
            yield return new object[] { new string[] { "item1", "item2" } };
            yield return new object[] { new string[] { "item1", null, "item3" } };
        }

        [Theory]
        [MemberData(nameof(Find_GetTestData))]
        public void Find_Should_ReturnCorrectLinkedListNode(string[] inputItems, string itemToSearch, ILinkedListNode expectedResult) {
            foreach (string item in inputItems)
                linkedList.Add(item);
            ILinkedListNode actualResult = linkedList.Find(itemToSearch);

            Assert.Equal(expectedResult?.Value, actualResult?.Value);
        }

        public static IEnumerable<object[]> Find_GetTestData() {
            /*empty list*/
            yield return CreateTestData<ILinkedListNode>(
                inputItems:     new string[] { },
                key:            "item1",
                expectedResult: null);
            /*no such item*/
            yield return CreateTestData<ILinkedListNode>(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item0",
                expectedResult: null);
            /*two such items, return first match*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item1", "item3" },
                key:            "item1",
                expectedResult: new SinglyLinkedListNode("item1"));
            /*found first item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item1",
                expectedResult: new SinglyLinkedListNode("item1"));
            /*found middle item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item2",
                expectedResult: new SinglyLinkedListNode("item2"));
            /*found last item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item3",
                expectedResult: new SinglyLinkedListNode("item3"));
        }

        [Theory]
        [MemberData(nameof(Remove_GetTestData))]
        public void Remove_Should_RemoveValueFromList(string[] inputItems, string itemToRemove, string[] expectedResult) {
            foreach (string item in inputItems)
                linkedList.Add(item);
            linkedList.Remove(itemToRemove);

            string[] actualItems = linkedList.ToArray();
            Assert.Equal(expectedResult, actualItems);
        }

        [Theory]
        [MemberData(nameof(Remove_GetTestDataWithBool))]
        public void Remove_Should_ReturnCorrectBool(string[] inputItems, string itemToRemove, bool expectedResult) {
            foreach (string item in inputItems)
                linkedList.Add(item);
            bool actualResult = linkedList.Remove(itemToRemove);

            Assert.Equal(expectedResult, actualResult);
        }

        public static IEnumerable<object[]> Remove_GetTestData() {
            /*empty list*/
            yield return CreateTestData(
                inputItems:     new string[] { },
                key:            "item1",
                expectedResult: new string[] { });
            /*no such item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item0",
                expectedResult: new string[] { "item1", "item2", "item3" });
            /*two such items, remove first match*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item1", "item3" },
                key:            "item1",
                expectedResult: new string[] { "item1", "item3" });
            /*remove first item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item1",
                expectedResult: new string[] { "item2", "item3" });
            /*remove middle item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item2",
                expectedResult: new string[] { "item1", "item3" });
            /*remove last item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item3",
                expectedResult: new string[] { "item1", "item2" });
        }

        public static IEnumerable<object[]> Remove_GetTestDataWithBool() {
            /*no such item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item0",
                expectedResult: false);
            /*remove first item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item1",
                expectedResult: true);
            /*remove not first item*/
            yield return CreateTestData(
                inputItems:     new string[] { "item1", "item2", "item3" },
                key:            "item2",
                expectedResult: true);  
        }

        public static object[] CreateTestData<T>(string[] inputItems, string key, T expectedResult) {
            return new object[] { inputItems, key, expectedResult };
        }
    }
}
