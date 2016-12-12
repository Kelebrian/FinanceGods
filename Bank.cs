using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class Bank
    {
        private static int RmuMinCost;
        private static int FpuMaxCost;
        private static double LoanPercent = 1;
        public static int currentMonth = 0;
        public static int currentLevel = 3;

        //ежемесячные постоянные издержки
        public static void FixedCosts(Player p)
        {
            p.State.Cash -= 300 * p.State.Rmu + 500 * p.State.Fpu + 
                1000 * p.State.CountFactory + 1500 * p.State.ACountFactory + 
                1 * p.State.LoanSum();
        }
        //вернуть ссуды
        public static void LoanRepay(Player p, double loan)
        {
            //p.State.Loan -= loan;
        }

        //получить ссуду
        public static void GetLoan(Player p, int loanSize)
        {
            if (p.State.LoanSum() > (p.State.CountFactory * 5000 + p.State.ACountFactory * 10000) / 2 ||
                loanSize > p.State.CountFactory * 5000 + p.State.ACountFactory * 10000)
            {
            }
            else 
            {
                p.State.Loan.Add(new Loan(loanSize, currentMonth));
            }
        }
        //увеличивает текущий месяц 
        public static void CurrentMonth()
        {
            currentMonth++;
        }

        //всякие заявки пошли
        public static void RMURequest()
        {
        }
        public static void FPURequest()
        { }

    }
}
