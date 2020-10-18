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
        private int passNumber;
        public int[] Array { get; set; }

        public SelectionSort(int[] array)
        {
            Array = array;
        }

        public bool Finished()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public StepChanges Step()
        {
            throw new NotImplementedException();
        }
    }
}
