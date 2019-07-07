using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    public class CurrentAccount : Account
    {
        private int withdrawCounter;
        private static int allowedWithdrawals;
        private static double deductionAmountDefault;
        private double amountDeducted;
        static CurrentAccount()
        {
            deductionAmountDefault = 4.5 / 100;
            allowedWithdrawals = 3;
        }

        public CurrentAccount (AccountType accountType, string name, int age, string address, double amount) :base(accountType, name, age, address, amount)
	    {
            withdrawCounter = 0;   
	    }

        public void deductAmount(TransactionType transactionType)
        {
            amountDeducted = base.balance * deductionAmountDefault;
            withdraw(amountDeducted, transactionType);
        }

        public override bool withdraw(double amount, TransactionType transactionType)
        {
            ++withdrawCounter;
            Console.WriteLine(withdrawCounter);
            bool success = base.withdraw(amount, transactionType);
            if (withdrawCounter > allowedWithdrawals)
            {
                withdrawCounter = 0;
                deductAmount(TransactionType.FINE_CHARGE);
                withdrawCounter--;
            }
            return success;
        }
    }
}
