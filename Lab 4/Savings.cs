using System;
using System.Collections.Generic;
using System.Text;

namespace JGreenLab4 {
    class Savings : Account {
        public Savings(double savingsBalance) : base(savingsBalance) { }

        public override void withdraw(double withdrawAmount) {
            if (withdrawAmount < getAccountBalance()) {
                setAccountBalance(getAccountBalance() - withdrawAmount);
            } 
            if (getAccountBalance() < 500) {
                Console.WriteLine("Charging a fee of $10 because you are below" +
                    " $500");
                setAccountBalance(getAccountBalance() - 10);
            }
        }

        public override void deposit(double depositAmount) {
            int count = 0;
            count++;

            Console.WriteLine("This is deposit " + count + "to this account.");

            if(count > 6) {
                Console.WriteLine("Charging a fee of $10");
                setAccountBalance(getAccountBalance() - 10);
            }
        }

        public void interest() {
            double annualInterestRate = 1.5;
            double monthlyInterestRate = (annualInterestRate / 100) / 12;
            double monthlyInterest = getAccountBalance() * monthlyInterestRate;

            Console.WriteLine("Customer earned " + monthlyInterest + " in interest.");

            setAccountBalance(getAccountBalance() + monthlyInterest);
        }
    }
}