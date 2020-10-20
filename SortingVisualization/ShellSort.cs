using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public class ShellSort : ISortAlgorithm
    {
        private int d;
        private int i;
        private int j;

        public int[] Array { get; set; }
        
        public ShellSort(int[] array)
        {
            Array = array;
            Reset();
        }

        public bool Finished()
        {
            return d == 1 && i >= Array.Length;
        }

        public void Reset()
        {
            d = Array.Length / 2;
            i = d;
            j = i - 1;
        }

        public StepChanges Step()
        {
            StepChanges sc = null;
            if(i >= Array.Length)
            {
                d /= 2;
                i = d;
                j = i - 1; ;
                return null;
            }
            if(d > 1)
            {
                if (Array[i - d] > Array[i])
                {
                    Helpers.Swap(Array, i - d, i);
                    sc = new StepChanges(i - d, i, true);
                }
                else sc = new StepChanges(i - d, i, false);
                ++i;
                return sc;
            }
            else
            {
                if(j < 0)
                {
                    ++i;
                    j = i - 1;
                    return null;
                }
                if(Array[j] > Array[j + 1])
                {
                    Helpers.Swap(Array, j, j + 1);
                    --j;
                    return new StepChanges(j + 1, j + 2, true);
                }
                else
                {
                    ++i;
                    j = i - 1;
                    return new StepChanges(j + 1, j + 2, false);
                }
            }
        }
    }
}
