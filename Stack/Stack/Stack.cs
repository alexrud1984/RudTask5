using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        //fields
        private int top = 0;
        private int[] targetStack;
        
        //methods
        public int Pop()                                            //returns top value in the stack
        {
            if (top == 0)
            {
                return (0);                                       //return 0 if stack is empty
            }
            else
            {
                return (targetStack[--top]);                       //return top value and decrease pointer
            }
        }

        public void Push(int value)                                 //push the value to the next free sell
        {
            if (top != targetStack.Length)
            {
                targetStack[top] = value;                             
                top++;
                return;
            }
            else
            {
                return;
            }
        }

        public bool IsEmpty()                                       //return true if stack is empty
        {
            if (top == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public bool IsFull()                                        //return true if stack is full
        {
            if (top == targetStack.Length)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public int Peek()                                           //return top value without deletion
        {
            if (top == 0)
            {
                return (0);
            }
            else
            {
               return ( targetStack[top - 1]);
            }
        }

        //constructor
        public Stack(int size)
        {
            targetStack = new int[size];
        }

    }
}
