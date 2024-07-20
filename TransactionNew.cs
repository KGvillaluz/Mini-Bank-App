using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class TransactionNew
    {
        //public int transactionID;

        public int AccountID {  get; set; }
        public float Amount { get; set; }
        public string TransactionType {  get; set; }

        public TransactionNew() { } 
        public TransactionNew(int accountID, float amount, string transactionType)
        {
            AccountID = accountID;
            Amount = amount;
            TransactionType = transactionType;
        }
    }
}
