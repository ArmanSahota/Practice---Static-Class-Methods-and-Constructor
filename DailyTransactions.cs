using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Static_Class__Methods__and_Constructor
{
    internal class DailyTransactions
    {
        
        static DailyTransactions()
       
        {
            _transactions = new List<Transaction>();
        }
        static List<Transaction> _transactions;

        public static void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }
        public static double CalculateTotal()
        {
            double total = 0;
            foreach (Transaction transaction in _transactions)
            {
                total += transaction.Amount;
            }
            return total * (1 + BusinessInfo.TaxAmount);
        }

        public static void DisplayAllInfo() 
        {
            {
                Console.WriteLine(BusinessInfo.BusinessName, ":");
                Console.WriteLine("All transactions:");
                foreach (Transaction transaction in _transactions)
                {
                    Console.WriteLine(transaction.ToString());
                }
                Console.WriteLine($"Total after taxes of {BusinessInfo.TaxAmount * 100}%: {CalculateTotal()}");
            }



        }


    }
}
