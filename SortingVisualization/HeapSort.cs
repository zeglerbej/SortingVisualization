using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public class HeapSort : ISortAlgorithm
    {
        int parent;
        int child;
        bool makeHeap;
        bool goDownHeap;
        int i;
        public int[] Array { get; set; }

        public HeapSort(int[] array)
        {
            Array = array;
            Reset();
        }

        public bool Finished()
        {
            return !makeHeap && i <= 0;
        }

        public void Reset()
        {
            i = Array.Length - 1;
            makeHeap = true;
            goDownHeap = false;
            parent = Array.Length / 2 - 1;
            GetChild(parent);
        }

        public StepChanges Step()
        {
            if(parent < 0)
            {
                makeHeap = false;
                parent = 0;
                return null;
            }
            if(makeHeap) return DownHeap();
            else
            {
                if(!goDownHeap)
                {
                    goDownHeap = true;
                    Helpers.Swap(Array, 0, i);
                    --i;
                    GetChild(0);
                    return new StepChanges(0, i, true);
                }              
                return DownHeap();
            }
        }
        
        private StepChanges DownHeap()
        {
            StepChanges sc = null;
            if (child > i)
            {
                if (makeHeap)
                {
                    --parent;
                    GetChild(parent);
                }
                else
                {
                    GetChild(0);
                    goDownHeap = false;
                }
                return null;
            }           
            if (Array[(child - 1) / 2] < Array[child])
            {
                Helpers.Swap(Array, (child - 1) / 2, child);
                sc = new StepChanges((child - 1) / 2, child, true);
            }
            else sc = new StepChanges((child - 1) / 2, child, false);
            GetChild(child);
            return sc;
        }

        private void GetChild(int parent)
        {
            if (parent < 0 || parent * 2 + 1 > i)
            {
                child = Array.Length;
                return;
            }
            if (parent * 2 + 2 > i) child = parent * 2 + 1;
            else child = Array[parent * 2 + 1] > Array[parent * 2 + 2] ? parent * 2 + 1 : parent * 2 + 2;
        }
    }
}
