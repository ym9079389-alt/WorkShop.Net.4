using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Net._4
{
    internal class MyStack<T>
    {
        private T[] members;
        private int top;
        public int count => top;

        public MyStack(int size)
        {
            members = new T[size];
            top = 0;
        }

        public void Push(T num)
        {
            if(top < members.Length)
            {
                members[top] = num;
                top++;
            }
        }

        public T? Pop()
        {
            if (top > 0)
                return members[top - 1];
            else
                return default;
        }

        public T? Beak()
        {
            if (top > 0)
                return members[--top];
            else
                return default;
        }


    }
}
