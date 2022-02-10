using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
     /// <summary>
     /// This class is the Checking Account which has a fee associated with deposits and withdrawals
     /// </summary>
     public class CheckingAccount: Account
     {
          decimal transactionFee;

          /// <summary>
          /// This method initializes the transaction fee associated with the account
          /// </summary>
          /// <param name="userBalance"></param>
          /// <param name="userFeeAmount"></param>
          public CheckingAccount(decimal userBalance, decimal userFeeAmount) : base(userBalance)
          {
               transactionFee = userFeeAmount;
          }

          /// <summary>
          /// This method first credits (deposits) into the bank account then subtracts the transaction fee from the balance
          /// </summary>
          /// <param name="creditAmount"></param>
          public override void Credit(decimal creditAmount)
          {
               base.Credit(creditAmount);
               balance -= transactionFee;
          }

          /// <summary>
          /// This method first checks if the transaction is valid through the base class's debit function. If transaction is valid
          /// then money is withdrawn from the account and the transaction fee is subtracted from the balance as well
          /// </summary>
          /// <param name="debitAmount"></param>
          /// <returns></returns>
          public override bool Debit(decimal debitAmount)
          {
               bool transactionValid;

               transactionValid = base.Debit(debitAmount);

               if (transactionValid == true)
               {
                    balance -= transactionFee;
               }

               return transactionValid;

          }
     }
}
