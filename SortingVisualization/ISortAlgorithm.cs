using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    public interface ISortAlgorithm
    {
        StepChanges Step();
        bool Finished();
    }
}
