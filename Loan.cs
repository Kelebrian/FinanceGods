using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class Loan
    {
        public int Size { get; set; }
        public int Month { get; set; }
        public Loan() { }
        public Loan(int size, int month)
        {
            Size = size;
            Month = month;
        }
    }
}
