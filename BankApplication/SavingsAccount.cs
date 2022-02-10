using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApplication
{
     /// <summary>
     /// Savings Account class basically calculates the interest earned on your savings account
     /// </summary>
     public class SavingsAccount : Account
     {
          decimal interestRate;

          /// <summary>
          /// Constructor for initializing interest rate
          /// </summary>
          /// <param name="userBalance"></param>
          /// <param name="userInterestRate"></param>
          public SavingsAccount(decimal userBalance, decimal userInterestRate) : base(userBalance)
          {
               interestRate = userInterestRate;
          }

          /// <summary>
          /// Calculates the interest earned on the account by multiplying account balance by interest rate
          /// </summary>
          /// <returns></returns>
          public decimal CalculateInterest()
          {
               decimal interestEarned;

               interestEarned = interestRate * balance;

               return interestEarned;
          }

         
     }

}

