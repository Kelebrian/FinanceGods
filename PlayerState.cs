using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class PlayerState
    {
        public int Rmu { get; set; }
        public int Fpu { get; set; }
        public int Cash { get; set; }
        public int CountFactory { get; set; }
        public int ACountFactory { get; set; }
        public List<Loan> Loan { get; set; } //ссуда
        public bool Status { get; set; }

        public PlayerState() { }
        public PlayerState(int rmu, int fpu, int cash, int countFactory, int aCountFactory, List<Loan> loan, bool status)
        {
            Rmu = rmu;
            Fpu = fpu;
            Cash = cash;
            CountFactory = countFactory;
            ACountFactory = aCountFactory;
            Loan = loan;
            Status = status;
        }
        public int LoanSum()
        {
            int sum = 0;
            foreach (Loan l in Loan)
            {
                sum += l.Size;
            }
            return sum;
        }
    }
}
