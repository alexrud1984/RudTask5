using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        //fields
        private int[] queue;
        private int tail = 0;
        private int head = 0;
        private int count = 0;

        //methods
        public void Engueue(int value)
        {
            if (IsFull())
            {
                return;                                                
            }
            else
            {
                queue[tail] = value;
                tail++;
                count++;
                if (tail == queue.Length)
                {
                    tail = 0;
                }
            }
        }

        public int Dequeue()
        {
            int pointer = head;
            if (IsEmpty())
            {
                return (0);                                          //return 0 if queue is empty
            }
            else
            {
                head++;
                count--;
                if (head == queue.Length)
                {
                    head = 0;
                }
                return (queue[pointer]);
            }
        }

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public bool IsFull()
        {
            if (count == queue.Length)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //constructor
        public Queue(int size)
        {
            queue = new int [size];
        }

    }
}
