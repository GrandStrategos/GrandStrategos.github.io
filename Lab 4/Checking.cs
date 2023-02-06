using System;
using System.Collections.Generic;
using System.Text;

namespace JGreenLab4 {
    class Checking : Account {
        double overdraftLimit = 0;
        public Checking(double checkingBalance) : base(checkingBalance) { }

        public override void withdraw(double withdrawAmount) {
            if (getAccountBalance() - withdrawAmount > overdraftLimit) {
                setAccountBalance(getAccountBalance() - withdrawAmount);
            } else if (getAccountBalance() - withdrawAmount < overdraftLimit) {
                Console.WriteLine("Charging an overdraft fee of $20 because" +
                    " account is below $0");
                setAccountBalance(getAccountBalance() - 20);
            }
        }
    }
}