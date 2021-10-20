using System;

namespace PracticeExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(4);
            stack.Push(9);
            stack.Push(11);
            stack.Push(15);
            stack.Push(19);
            stack.Push(21);

            Console.WriteLine(stack);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);


            Console.WriteLine(queue);
        }
    }
}
