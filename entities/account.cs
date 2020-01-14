using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança.entities
{
    class account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public account()
        {
        }

        public account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }






    }
}
