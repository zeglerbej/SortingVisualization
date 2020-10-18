using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public class QuickSort : ISortAlgorithm
    {
        public int[] Array { get; set ; }
        private Queue<int[]> queue;
        int i;
        int border;
        bool takeNextGroup;
        int[] group;

        public QuickSort(int[] array)
        {
            Array = array;
            queue = new Queue<int[]>();
            Reset();
        }

        public bool Finished()
        {
            return queue.Count == 0 && takeNextGroup;
        }

        public void Reset()
        {
            queue.Clear();
            queue.Enqueue(new int[] {0, Array.Length - 1});
            i = -1;
            border = -1;
            takeNextGroup = true;
            group = null;
        }

        public StepChanges Step()
        {
            StepChanges sc = null;
            if (takeNextGroup)
            {
                group = queue.Dequeue();
                takeNextGroup = false;
                i = group[0];
                border = group[0];
            }
            if(i == group[1])
            {
                if (border - group[0] > 1) queue.Enqueue(new int[] { group[0], border - 1});
                if(group[1] - border > 1) queue.Enqueue(new int[] { border + 1, group[1]});
                Helpers.Swap(Array, border, group[1]);
                takeNextGroup = true;
                return null;
            }
            if (Array[i] < Array[group[1]])
            {
                Helpers.Swap(Array, i, border);
                sc = new StepChanges(i, group[1], true);
                ++border;
            }
            else
            {
                sc = new StepChanges(i, border, false);
            }
            ++i;
            return sc;
        }
    }
}
