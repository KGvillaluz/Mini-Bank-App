using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    internal class Transaction
    {
        private int accountID;
        
        private string transaction_type;

        public int AccountID
        {
            get { return  accountID; }
            set { accountID = value; }
        }

        public string TransactionType
        {
            get { return transaction_type; }
            set { transaction_type = value; }
        }

        string connstring = "Data Source=C:\\Users\\kians\\atm.db;Version=3;";

        public void saveTransaction()
        {
            int transactionID = generateTransactionID();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connstring))
                {
                    string query = "INSERT INTO transactions (transactionID, accountID, transaction_type) VALUES (@tID, @aID, @type);";

                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tID", transactionID);
                        command.Parameters.AddWithValue("@aID", AccountID);
                        command.Parameters.AddWithValue("@type", transaction_type);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public int generateTransactionID()
        {
            Random random = new Random();

            return random.Next(1000, 3000);
        }
    }
}
