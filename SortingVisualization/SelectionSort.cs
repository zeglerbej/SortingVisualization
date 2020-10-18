using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public class SelectionSort : ISortAlgorithm
    {
        private int i;
        private int max;
        private int maxInd;
        private int passNumber;
        public int[] Array { get; set; }

        public SelectionSort(int[] array)
        {
            Array = array;
            Reset();
        }

        public bool Finished()
        {
            return passNumber == Array.Length;
        }

        public void Reset()
        {
            i = 1;
            max = Array[0];
            passNumber = 1;
            maxInd = 0;
        }

        public StepChanges Step()
        {
            StepChanges sc = null;
            if(Array[i] > max)
            {
                sc = new StepChanges(i, maxInd, false);
                max = Array[i];
                maxInd = i;
            }
            else sc = new StepChanges(i, maxInd, true);
            if (i == Array.Length - passNumber)
            {
                Helpers.Swap(Array, maxInd, i);
                sc = new StepChanges(i, maxInd, i != maxInd);
                ++passNumber;
                i = 1;
                max = Array[0];
                maxInd = 0;
                return sc;
            }
            ++i;
            return sc;
        }
    }
}
