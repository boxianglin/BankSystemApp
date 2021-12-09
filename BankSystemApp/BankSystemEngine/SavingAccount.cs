﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemEngine
{
    /// <summary>
    /// Saving account inherited from bankaccount.
    /// </summary>
    public class SavingAccount : BankAccount
    {
        /// <summary>
        /// Default interest rate gain for saving account.
        /// </summary>
        private readonly double interest = 0.5;

        /// <summary>
        /// Initializes a new instance of the <see cref="SavingAccount"/> class.
        /// </summary>
        /// <param name="accNumber"> account number. </param>
        public SavingAccount(int accNumber)
            : base(accNumber)
        {
        }

        /// <summary>
        /// Saving acc deposit interface by Command pattern.
        /// </summary>
        /// <param name="command"> Deposit command. </param>
        /// <returns> can deposit or not. </returns>
        public bool DepositSaving(DepositCommand command)
        {
            bool isSuccess = command.Execute();
            return isSuccess;
        }

        /// <summary>
        /// Saving acc withdraw interface by COmmand pattern.
        /// </summary>
        /// <param name="command"> Withdraw Command. </param>
        /// <returns> can withdraw or not. </returns>
        public bool WithdrawSaving(WithdrawCommand command)
        {
            bool isSuccess = command.Execute();
            return isSuccess;
        }

        /// <summary>
        /// Show user the interest rate.
        /// </summary>
        /// <returns> interest rate in string. </returns>
        public string GetAccountInterestRate()
        {
            return string.Empty;
        }

    }
}
