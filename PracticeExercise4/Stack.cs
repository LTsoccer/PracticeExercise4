﻿using System;
using System.Collections.Generic;

namespace PracticeExercise4
{
    public class Stack<T> : IStack<T>
    {
        private LinkedList<T> linkedList;

        public Stack()
        {
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            T topOfStack = linkedList.Last.Value;
            linkedList.RemoveLast();

            return topOfStack;
        }

        public void Push(T item)
        {
            linkedList.AddLast( item );
        }
    }
}
