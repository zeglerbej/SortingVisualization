using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public class InsertionSort : ISortAlgorithm
    {
        private int i;
        private int j;
        private int[] array;

        public InsertionSort(int[] array)
        {
            this.array = array;
            i = 0;
            j = 1;
        }
        public void Reset()
        {
            i = 0;
            j = 1;
        }


        public bool Finished()
        {
            return j == array.Length;
        }

        public StepChanges Step()
        {
            if(i == -1 || array[i] < array[j])
            {
                int k = j;
                int temp = array[j];                
                while(k > i + 1)
                {
                    array[k] = array[k - 1];
                    --k;
                }
                array[i + 1] = temp;
                ++j;
                i = j - 1;
                return new StepChanges(Math.Max(i,0), j, true);
            }
            --i;
            return new StepChanges(Math.Max(i, 0), j, false);
        }
    }
}
