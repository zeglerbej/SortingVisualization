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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
