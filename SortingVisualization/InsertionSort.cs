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
        public int[] Array { get; set; }

        public InsertionSort(int[] array)
        {
            Array = array;
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
            return j == Array.Length;
        }

        public StepChanges Step()
        {
            if(i == -1 || Array[i] < Array[j])
            {
                int k = j;
                int temp = Array[j];                
                while(k > i + 1)
                {
                    Array[k] = Array[k - 1];
                    --k;
                }
                Array[i + 1] = temp;
                ++j;
                i = j - 1;
                return new StepChanges(Math.Max(i,0), j, false);
            }
            --i;
            return new StepChanges(Math.Max(i, 0), j, true);
        }
    }
}
