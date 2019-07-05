using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities.DTOs;
using Bank;

namespace Bank.Entities.DTOs
{
    class AccountDTO
    {
        private string name;
        private int age;
        private string address;
        private double balance;
        private int accountID;
        private AccountType accType;


        protected string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int Age
        {
            get { return age; }
            set { age = value; }
        }


        protected string Address
        {
            get { return address; }
            set { address = value; }
        }

        protected double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        protected int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public AccountType AccType
        {
            get { return accType; }
            set { accType = value; }
        }
        
    }
}
