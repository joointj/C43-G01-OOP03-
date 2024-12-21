using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal interface ISeries
    {
        public int Current { get; set; } // signature for property

        public void GetNext(); // signature for method
        public void Reset()
           => Current = 0;
    }
}
