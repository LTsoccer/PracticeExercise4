using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExercise4;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestStackPush()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(5);
            stack.Push(8);

            Assert.AreEqual(5, stack.Length);
            Assert.AreEqual("8\n5\n3\n2\n1\n", stack.ToString());
        }

        [TestMethod]
        public void TestStackPop()
        {
        }

        [TestMethod]
        public void TestStackPeek()
        {
        }

        [TestMethod]
        public void TestStackLength()
        {
        }

        [TestMethod]
        public void TestStackIsEmpty()
        {
        }

        [TestMethod]
        public void TestQueueEnqueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.AreEqual(5, queue.Length);
            Assert.AreEqual("<Back> 5 → 4 → 3 → 2 → 1 <Front>", queue.ToString());


            queue.Enqueue(6);
            queue.Enqueue(7);

            Assert.AreEqual(7, queue.Length);
            Assert.AreEqual("<Back> 7 → 6 → 5 → 4 → 3 → 2 → 1 <Front>", queue.ToString());
        }

        [TestMethod]
        public void TestQueueDequeue()
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            queue.Dequeue();
            queue.Dequeue();

            Assert.AreEqual(7, queue.Length);
            Assert.AreEqual("<Back> 9 → 8 → 7 → 6 → 5 → 4 → 3 <Front>", queue.ToString());

            queue.Dequeue();
            queue.Dequeue();
            Assert.AreEqual(5, queue.Length);
            Assert.AreEqual("<Back> 9 → 8 → 7 → 6 → 5 <Front>", queue.ToString());

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Assert.AreEqual(0, queue.Length);
            Assert.AreEqual("<Back>  <Front>", queue.ToString());

            Assert.ThrowsException<EmptyQueueException>(() =>
            {
                queue.Dequeue();
            });

            Queue<int> queue1 = new Queue<int>();
            Assert.ThrowsException<EmptyQueueException>(() =>
            {
                queue1.Dequeue();
            });

        }

        [TestMethod]
        public void TestQueueIsEmpty()
        {
        }

        [TestMethod]
        public void TestQueueLength()
        {
        }

        [TestMethod]
        public void TestQueueFirst()
        {
        }

        [TestMethod]
        public void TestQueueLast()
        {
        }


        [TestMethod]
        public void TestDequeAddFront()
        {
        }

        [TestMethod]
        public void TestDequeAddBack()
        {
        }

        [TestMethod]
        public void TestDequeRemoveFront()
        {
        }

        [TestMethod]
        public void TestDequeRemoveBack()
        {
        }

        [TestMethod]
        public void TestDequeIsEmpty()
        {
        }

        [TestMethod]
        public void TestDequeLength()
        {
        }

        [TestMethod]
        public void TestDequeFront()
        {
        }

        [TestMethod]
        public void TestDequeBack()
        {
        }

    }
}
