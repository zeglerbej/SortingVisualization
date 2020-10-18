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
        public int[] Array { get; set; }
        private int passNumber;

        public BubbleSort(int[] array)
        {
            Array = array;
            Reset();
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
            if(j == Array.Length - passNumber + 1)
            {
                i = 0;
                j = 1;
                ++passNumber;
            }
        }

        public StepChanges Step()
        {
            bool change = false;
            if(Array[i] > Array[j])
            {
                Helpers.Swap(Array, i, j);
                change = true;
            }
            ChangeIndices();

            return new StepChanges(i, j, change);
        }


        public bool Finished()
        {
            return passNumber == Array.Length;
        }
    }
}
