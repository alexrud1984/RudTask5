using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserValue = 0;
            string command;
            Queue queue = new Queue(5);
            do
            {
                Console.WriteLine("Put your command");
                switch (command = Console.ReadLine())
                {
                    case "enq":
                        if (queue.IsFull())
                        {
                            Console.WriteLine("The queue is full");
                            break;
                        }
                        Console.WriteLine("Put the integer value for enqueue");
                        UserValue = Convert.ToInt32(Console.ReadLine());
                        queue.Engueue(UserValue);
                        break;
                    case "deq":
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("The queue is empty");
                            break;
                        }
                        Console.WriteLine(queue.Dequeue());
                        break;
                    case "isempty":
                        Console.WriteLine(queue.IsEmpty());
                        break;
                    case "isfull":
                        Console.WriteLine(queue.IsFull());
                        break;
                    case "exit":
                        break;
                    case "help":
                        Console.WriteLine("Nobody can help you, all helpers are busy!");
                        break;
                    default:
                        Console.WriteLine("Unknown command see help");
                        break;
                }
            }
            while (command != "exit");
        }
    }
}
