using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSorter
    {
        private int[] targetMatrix;

        public void Sort()
        {
            bool SwapTrue = false;
            do
            {
                SwapTrue = false;
                for (int i = 0; i < (targetMatrix.Length - 1); i++)
                {
                    if (targetMatrix[i] > targetMatrix[i + 1])
                    {
                        Swap(i, (i + 1));
                        SwapTrue = true;
                    }
                }
            }
            while (SwapTrue);
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

        public BubbleSorter(int[] targetMatrix)
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
