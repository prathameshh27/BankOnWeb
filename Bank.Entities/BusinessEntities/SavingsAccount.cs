using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    public class SavingsAccount : Account
    {

        #region Variables
        private static double interestRateDefault;
        private double interestAwarded; 
        #endregion

        #region Constructor
        static SavingsAccount()
        {
            interestRateDefault = 6.5 / 100;
        } 

        public SavingsAccount (AccountType accountType, string name, int age, string address, double amount) :base(accountType, name, age, address, amount)
	    {
            
	    }
        
        #endregion

        public void addInterest()
        {
            interestAwarded = base.balance * interestRateDefault;
            base.depositeAmount(interestAwarded, TransactionType.INTEREST_BONUS);
        }
    }
}
