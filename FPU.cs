using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class FPU
    {
        public int Cost { get; set; } //цена ЕГП
        public int Count { get; set; } //количество
        public FPU() { }
        public FPU(int cost, int count)
        {
            Cost = cost;
            Count = count;
        }
    }
}
