using Bank.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    public class Account
    {
        #region Variables
        protected string name;
        protected int age;
        protected string address;
        protected double balance;
        protected int accountID;
        protected AccountType accountType; 

        protected List<Transaction> transactionList = new List<Transaction>();
        protected Transaction transaction;

        protected static int idCounter;
        protected static double minimumDeposite;
        protected static string success;
        protected static string failure;
        #endregion

        #region Properties
        public static int IdCounter
        {
            get { return Account.idCounter; }
            //set { Account.idCounter = value; }
        }
        public static double MinimumDeposite
        {
            get { return Account.minimumDeposite; }
            //set { Account.minimumDeposite = value; }
        }
        #endregion

        #region Constructors
        static Account()
        {
            idCounter = -1;
            minimumDeposite = 5000.00;
        }

        public Account()
        {
            balance = 0.0;
            accountID = ++idCounter;
        }

        public Account(AccountType accountType, string name, int age, string address, double amount): this()
        //public Account(AccountDTO accountDTO): this()
        {
            this.accountType = accountType;
            this.name = name;
            this.age = age;
            this.address = address;
            this.balance = this.balance + amount;
            transactionList.Add(new Transaction(amount, TransactionType.DEPOSITE));
        } 
        #endregion

        #region Methods
        public override string ToString()   //Account Details
        {
            return "Name\t: " + name + "\nAge\t: " + age + "\nAddress\t: " + address + "\nBalance\t: " + balance;
        }
        
        public void showTransactions()     //To be removed
        {
            Console.WriteLine("\nAmount \t\t\t Type \t\t DateTime");
            foreach(Transaction transaction in transactionList)
            {
                Console.WriteLine(transaction.Amount + "\t\t\t" + transaction.TransactionType + "\t" + transaction.Date);
            }
        }

        public void updateTransaction(double amount, TransactionType transactionType)
        {
            this.transaction = new Transaction(amount, transactionType);
            transactionList.Add(this.transaction);
        }
        
        public virtual bool depositeAmount(double amount, TransactionType transactionType)
        {
            if (amount > 0)
            {
                balance += amount;
                updateTransaction(amount, transactionType);
                return true;
            }
            else return false;                
        }

        public virtual bool withdraw(double amount, TransactionType transactionType)
        {
            if(amount>0)
            {
                if (amount < balance)
                {
                    balance -= amount;
                    updateTransaction(amount, transactionType);
                    return true;
                }
                else return false;                
            }
            else return false;                
        } 
        #endregion
    }
}
