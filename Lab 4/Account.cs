using System;
using System.Collections.Generic;
using System.Text;

namespace JGreenLab4 {
    class Account {
        Random num = new Random();
        private static int accNumber;
        private double accBalance;

        public Account() {
            accNumber = num.Next();
            accBalance = 0;
        }

        public Account(double balance) {
            this.accBalance = balance;
            accNumber = num.Next();
        }

        public int getAccountNumber() {
            accNumber = num.Next();
            return accNumber;
        }

        public double getAccountBalance() {
            return accBalance;
        }

        public void setAccountBalance(double accountBalance) {
            this.accBalance = accountBalance;
        }

        public virtual void withdraw(double withdrawAmount) {
            accBalance -= withdrawAmount;
        }

        public virtual void deposit(double depositAmount) {
            accBalance += depositAmount;
        }
    }
}