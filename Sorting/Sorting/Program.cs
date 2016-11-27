using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UserArray = new int [] {9, -9, 100, 0, -99, 50 , 12, -18, 10, 5};
            BubbleSorter bubbleMtrx = new BubbleSorter((int[]) UserArray.Clone());
            bubbleMtrx.Print();
            bubbleMtrx.Sort();
            bubbleMtrx.Print();
            InsertionSorter insertionMtrx = new InsertionSorter((int[]) UserArray.Clone());
            insertionMtrx.Print();
            insertionMtrx.Sort();
            insertionMtrx.Print();
            Console.ReadKey();
        }
    }
}