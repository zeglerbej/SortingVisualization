using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public class MergeSort : ISortAlgorithm
    {
        private Queue<int[]> queue;
        public int[] Array { get; set; }
        private int i;
        private int j;
        private int k;
        private bool takeNextGroup;
        private int[] helpArray;
        private int[] group;

        public MergeSort(int[] array)
        {
            queue = new Queue<int[]>();
            Array = array;
            Reset();
        }
        public bool Finished()
        {
            return queue.Count == 0 && takeNextGroup;
        }

        public void Reset()
        {
            queue.Clear();
            Divide(0,Array.Length - 1);
            i = -1;
            j = -1;
            k = -1;
            takeNextGroup = true;
            helpArray = null;
            group = null;
        }
        
        private void Divide(int p, int r)
        {
            if (p == r) return;
            int q = (p + r) / 2;
            Divide(p, q);
            Divide(q + 1, r);
            queue.Enqueue(new int[] { p, q, r });
        }

        public StepChanges Step()
        {
            StepChanges sc = null;
            if (takeNextGroup)
            {
                takeNextGroup = false;
                group = queue.Dequeue();
                takeNextGroup = false;
                i = group[0];
                j = group[1] + 1;
                k = 0;
                helpArray = new int[group[2] - group[0] + 1];
            }
            while(i <= group[1] && j <= group[2])
            {
                if(Array[i] > Array[j])
                {
                    sc = new StepChanges(i, j, true);
                    helpArray[k] = Array[j];
                    ++k;
                    ++j;
                    return sc;
                }
                else
                {
                    sc = new StepChanges(i, j, false);
                    helpArray[k] = Array[i];
                    ++k;
                    ++i;
                    return sc;
                }
            }
            while(i <= group[1])
            {
                helpArray[k] = Array[i];
                ++k;
                ++i;
            }
            while (j <= group[2])
            {
                helpArray[k] = Array[j];
                ++k;
                ++j;
            }
            for(int m = group[0]; m <= group[2]; ++m)
            {
                Array[m] = helpArray[m - group[0]];
            }
            takeNextGroup = true;
            return null;
        }
    }
}
