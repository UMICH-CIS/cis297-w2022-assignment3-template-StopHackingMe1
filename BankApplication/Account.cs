using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
     /// <summary>
     /// This class is for a general bank account which holds balance
     /// </summary>
     public class Account
     {
          protected decimal balance;
         
          /// <summary>
          /// Property that gets the balance of the account
          /// </summary>
          public decimal Balance
          {
               get { return balance; }

          }

          /// <summary>
          /// Constructor that initializes balance. If the balance that is passed is negative, an error message prints and program exits
          /// </summary>
          /// <param name="userBalance"></param>
          public Account(decimal userBalance)
          {
               if (userBalance <= 0m)
               {
                    Console.WriteLine("Error: User Balance cannot be nagative. Ending Program...");
                    Console.ReadKey();
                    Environment.Exit(1);
               }
               else
               {
                    balance = userBalance;
               }

          }

          /// <summary>
          /// This method adds money to the current balance (a deposit) based on how much creditAmount is
          /// </summary>
          /// <param name="creditAmount"></param>
          public virtual void Credit(decimal creditAmount)
          {
               balance += creditAmount;
          }

          /// <summary>
          /// This method substracts money from the balance based on debitAmount (a withdrawal). If the amount withdrawn is more than
          /// what is in the balance, the transaction will not be completed.
          /// </summary>
          /// <param name="debitAmount"></param>
          /// <returns></returns>
          public virtual bool Debit(decimal debitAmount)
          {
               bool transactionCompleted;

               if (debitAmount > balance)
               {
                    Console.WriteLine("Debit amount exceeded account balance");
                    transactionCompleted = false;
               }
               else
               {
                    balance -= debitAmount;
                    transactionCompleted = true;
               }

               return transactionCompleted;
          }


     }
}

