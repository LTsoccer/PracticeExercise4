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
            stack.Push(3);
            stack.Push(5);
            stack.Push(8);
            stack.Push(13);
            stack.Push(21);

            Console.WriteLine(stack);



            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue);


            Console.ReadKey();

        }
    }
}
