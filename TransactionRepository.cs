using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class TransactionRepository
    {
        private string _connstring = Connection.path;
        private int _transactionID;
        public void saveTransaction(TransactionNew transaction)
        {
            _transactionID = generateTransactionID();

            using (var connection = new SQLiteConnection(_connstring))
            {
                connection.Open();
                string query = "INSERT INTO transactions (transactionID, accountID, amount, transaction_type) VALUES (@tID, @aID, @amount, @type)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tID", _transactionID);
                    command.Parameters.AddWithValue("@aID", transaction.AccountID);
                    command.Parameters.AddWithValue("@amount", transaction.Amount);
                    command.Parameters.AddWithValue("@type", transaction.TransactionType);
                    
                    if (command.ExecuteNonQuery() > 0)
                    {
                        Receipt receipt = new Receipt();
                        Receipt.transactionID = _transactionID;
                        Receipt.transactionType = transaction.TransactionType;
                        Receipt.amount = transaction.Amount;
                        receipt.printReceipt();
                    }
                }
            }
        }

        private int generateTransactionID()
        {
            Random rand = new Random();
            var num = rand.Next(1000, 5000);

            return num;
        }
    }
}
