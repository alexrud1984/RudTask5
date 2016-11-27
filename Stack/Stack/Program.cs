using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            string command;
            int userValue = 0;
            do
            {
                Console.WriteLine("Put your command");
                switch (command = Console.ReadLine())
                {
                    case "push":
                        if (stack.IsFull())
                        {
                            Console.WriteLine("The stack is full");
                            break;
                        }
                        Console.WriteLine("Put the integer value for push");
                        userValue = Convert.ToInt32(Console.ReadLine());
                        stack.Push(userValue);
                        break;
                    case "pop":
                        if (stack.IsEmpty())
                        {
                            Console.WriteLine("The sthack is empty");
                            break;
                        }
                        Console.WriteLine(stack.Pop());
                        break;
                    case "isempty":
                        Console.WriteLine(stack.IsEmpty());
                        break;
                    case "isfull":
                        Console.WriteLine(stack.IsFull());
                        break;
                    case "peek":
                        if (stack.IsEmpty())
                        {
                            Console.WriteLine("The sthack is empty");
                            break;
                        }
                        Console.WriteLine(stack.Peek());
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
