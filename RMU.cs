using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class RMU
    {
        public int Cost { get; set; } //цена ЕСМ
        public int Count { get; set; } //количество
        public RMU() { }
        public RMU(int cost, int count)
        {
            Cost = cost;
            Count = count;
        }
    }
}
