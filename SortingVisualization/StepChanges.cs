using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public class StepChanges
    {
        public int i;
        public int j;
        public bool swaped;

        public StepChanges(int i, int j, bool swaped)
        {
            this.i = i;
            this.j = j;
            this.swaped = swaped;
        }
    }
}
