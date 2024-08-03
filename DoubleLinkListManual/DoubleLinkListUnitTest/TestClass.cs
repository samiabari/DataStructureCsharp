using System.Collections.Generic;
using DoubleLinkListManual;
namespace DoubleLinkListUnitTest
{
    public class TestClass
    {

        [Fact]
        public void AddFirst_ShouldAddNodeToEmptyList()
        {
            // Arrange
            var list = new LinkList<int>();

            // Act
            list.AddFirst(10);

            // Assert
            Assert.NotNull(list.Head);
            Assert.NotNull(list.Tail);
            Assert.Equal(10, list.Head.Data);
            Assert.Equal(10, list.Tail.Data);
            Assert.Equal(list.Head, list.Tail);
        }


        [Fact]
        public void AddFirst_ShouldAddNodeToNonEmptyList()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddFirst(20);

            // Act
            list.AddFirst(10);

            // Assert
            Assert.NotNull(list.Head);
            Assert.NotNull(list.Tail);
            Assert.Equal(10, list.Head.Data);
            Assert.Equal(20, list.Tail.Data);
            Assert.Equal(20, list.Head.Next.Data);
            Assert.Equal(10, list.Tail.Prev.Data);
        }


        [Fact]
        public void AddLast_ShouldAddNodeToEmptyList()
        {
            // Arrange
            var list = new LinkList<int>();

            // Act
            list.AddLast(10);

            // Assert
            Assert.NotNull(list.Head);
            Assert.NotNull(list.Tail);
            Assert.Equal(10, list.Head.Data);
            Assert.Equal(10, list.Tail.Data);
            Assert.Equal(list.Head, list.Tail);
        }


        [Fact]
        public void AddLast_ShouldAddNodeToNonEmptyList()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(20);

            // Act
            list.AddLast(30);

            // Assert
            Assert.NotNull(list.Head);
            Assert.NotNull(list.Tail);
            Assert.Equal(20, list.Head.Data);
            Assert.Equal(30, list.Tail.Data);
            Assert.Equal(30, list.Head.Next.Data);
            Assert.Equal(20, list.Tail.Prev.Data);
        }

        [Fact]
        public void AddAfter_ShouldAddNodeAfterSpecifiedNode()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            list.AddAfter(10, 15);

            // Assert
            Assert.Equal(15, list.Head.Next.Data);
            Assert.Equal(20, list.Head.Next.Next.Data);
            Assert.Equal(15, list.Tail.Prev.Data);
        }

        [Fact]
        public void AddAfter_ShouldAddNodeAtEndIfSpecifiedNodeIsTail()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            list.AddAfter(20, 25);

            // Assert
            Assert.Equal(25, list.Tail.Data);
            Assert.Equal(20, list.Tail.Prev.Data);
        }


        [Fact]
        public void AddBefore_ShouldAddNodeBeforeSpecifiedNode()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(20);
            list.AddLast(30);

            // Act
            list.AddBefore(30, 25);

            // Assert
            Assert.Equal(25, list.Head.Next.Data);
            Assert.Equal(30, list.Head.Next.Next.Data);
            Assert.Equal(25, list.Tail.Prev.Data);
        }

        [Fact]
        public void AddBefore_ShouldAddNodeAtBeginningIfSpecifiedNodeIsHead()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(20);
            list.AddLast(30);

            // Act
            list.AddBefore(20, 15);

            // Assert
            Assert.Equal(15, list.Head.Data);
            Assert.Equal(20, list.Head.Next.Data);
            Assert.Equal(15, list.Tail.Prev.Prev.Data);
        }


        [Fact]
        public void FindFirst_ShouldReturnNodeWithSpecifiedData()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            var node = list.FindFirst(20);

            // Assert
            Assert.NotNull(node);
            Assert.Equal(20, node.Data);
        }

        [Fact]
        public void FindFirst_ShouldReturnNullIfDataNotFound()
        {
            // Arrange
            var list = new LinkList<int>();

            // Act
            var node = list.FindFirst(10);

            // Assert
            Assert.Null(node);
        }


        [Fact]
        public void FindLast_ShouldReturnNodeWithSpecifiedData()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            var node = list.FindLast(20);

            // Assert
            Assert.NotNull(node);
            Assert.Equal(20, node.Data);
        }

        [Fact]
        public void FindLast_ShouldReturnNullIfDataNotFound()
        {
            // Arrange
            var list = new LinkList<int>();

            // Act
            var node = list.FindLast(10);

            // Assert
            Assert.Null(node);
        }


        [Fact]
        public void Remove_ShouldRemoveNodeWithSpecifiedData()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Act
            var result = list.Remove(20);

            // Assert
            Assert.True(result);
            Assert.Equal(10, list.Head.Data);
            Assert.Equal(30, list.Head.Next.Data);
            Assert.Equal(10, list.Tail.Prev.Data);
        }

        [Fact]
        public void Remove_ShouldReturnFalseIfDataNotFound()
        {
            // Arrange
            var list = new LinkList<int>();

            // Act
            var result = list.Remove(10);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveFirst_ShouldRemoveHeadNode()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            var result = list.RemoveFirst();

            // Assert
            Assert.True(result);
            Assert.Equal(20, list.Head.Data);
            Assert.Null(list.Head.Prev);
        }

        [Fact]
        public void RemoveFirst_ShouldReturnFalseIfListIsEmpty()
        {
            // Arrange
            var list = new LinkList<int>();

            // Act
            var result = list.RemoveFirst();

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void RemoveLast_ShouldRemoveTailNode()
        {
            // Arrange
            var list = new LinkList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            var result = list.RemoveLast();

            // Assert
            Assert.True(result);
            Assert.Equal(10, list.Tail.Data);
            Assert.Null(list.Tail.Next);
        }

        [Fact]
        public void RemoveLast_ShouldReturnFalseIfListIsEmpty()
        {
            // Arrange
            var list = new LinkList<int>();

            // Act
            var result = list.RemoveLast();

            // Assert
            Assert.False(result);
        }
    }
}