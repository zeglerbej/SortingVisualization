using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public class BubbleSort: ISortAlgorithm
    {
        private int i;
        private int j;
        private int[] array;
        private int passNumber;

        public BubbleSort(int[] array)
        {
            this.array = array;
            i = 0;
            j = 1;
            passNumber = 1;
        }

        public void Reset()
        {
            i = 0;
            j = 1;
            passNumber = 1;
        }

        private void ChangeIndices()
        {
            ++i;
            ++j;
            if(j == array.Length - passNumber + 1)
            {
                i = 0;
                j = 1;
                ++passNumber;
            }
        }

        public StepChanges Step()
        {
            bool change = false;
            if(array[i] > array[j])
            {
                Helpers.Swap(array, i, j);
                change = true;
            }
            ChangeIndices();

            return new StepChanges(i, j, change);
        }


        public bool Finished()
        {
            return passNumber == array.Length;
        }
    }
}
