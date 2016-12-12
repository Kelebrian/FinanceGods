using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class Bound
    {
        public Bound() { }
        public Bound(double min, double max)
        {
            Min = min;
            Max = max;
        }
        public double Min { get; set; }
        public double Max { get; set; }
    }
}
