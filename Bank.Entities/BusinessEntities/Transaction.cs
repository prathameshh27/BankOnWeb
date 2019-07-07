using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    public struct Transaction
    {
        double amount;
        TransactionType transactionType;
        DateTime date;

        #region Properties
        public double Amount
        {
            get { return amount; }
            //set { amount = value; }
        }

        public TransactionType TransactionType
        {
            get { return transactionType; }
            //set { transactionType = value; }
        }

        public DateTime Date
        {
            get { return date; }
            //set { date = value; }
        } 
        #endregion

        public Transaction(double amount, TransactionType transactionType)
        {
            this.amount = amount;
            this.transactionType = transactionType;
            this.date = DateTime.Now;
        }
    }
}
