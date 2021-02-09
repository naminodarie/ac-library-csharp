﻿using System.Collections.Generic;

namespace AtCoder.Internal
{
    public interface IPriorityQueueOp<T, TOp> where TOp : IComparer<T>
    {
        int Count { get; }
        T Peek { get; }
        void Add(T value);
        T Dequeue();
        bool TryDequeue(out T result);
        void Clear();
    }
}
