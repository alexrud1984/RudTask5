using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class InsertionSorter
    {
        private int[] targetMatrix;

        public void Sort()
        {
            for (int i = 1; i < targetMatrix.Length; i++)
            {
                int pointer = i;
                while ((pointer > 0) && (targetMatrix[pointer - 1] > targetMatrix[pointer])) //do if current position >0 and previous sell is bigger than current. to Pavlo: is it correct? pointer-1 potentially==matrix[-1]?
                {
                    Swap(pointer - 1, pointer);                                         //swap previous with current
                    pointer--;                                                          //go to previous sell
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Array state");
            for (int i = 0; i < targetMatrix.Length; i++)
            {
                Console.Write(targetMatrix[i] + " ");
            }
            Console.WriteLine();
        }

        public InsertionSorter(int[] targetMatrix)
        {
            this.targetMatrix = targetMatrix;
        }

        private void Swap(int first, int second)
        {
            int bufferValue = targetMatrix[first];
            targetMatrix[first] = targetMatrix[second];
            targetMatrix[second] = bufferValue;
        }
        
    }
}
