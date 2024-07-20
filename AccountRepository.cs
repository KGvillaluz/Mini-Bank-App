using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    internal class AccountRepository
    { 
        //string _connstring = Connection.path;
        private int _customerID;
        public AccountRepository() 
        {

        }

        public bool createAcc(AccountsNew accounts)
        {
            float balance = 0.00F;
            Random rand = new Random();
            _customerID = rand.Next(1000, 5000);

            using (SQLiteConnection connection = new SQLiteConnection(Connection.path))
            {
                connection.Open();
                string insert = "INSERT INTO accounts (accountID, customerID, balance) VALUES (@Value1, @Value2, @Value3);";

                using (SQLiteCommand command = new SQLiteCommand(insert, connection))
                {
                    command.Parameters.AddWithValue("@Value1", AccountsNew.AccountID);
                    command.Parameters.AddWithValue("@Value2", _customerID);
                    command.Parameters.AddWithValue("@Value3", balance);

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool updateAcc(float amount, int accountID, bool isDeposit)
        {
            using (var connection = new SQLiteConnection(Connection.path))
            {
                connection.Open();
                string query = isDeposit ?
                    "UPDATE accounts SET balance = balance + @Amount WHERE accountID = @accountID" :
                    "UPDATE accounts SET balance = balance - @Amount WHERE accountID = @accountID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@accountID", accountID);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public float getBalance(int accountID, float balance)
        {
            using (var connection = new SQLiteConnection(Connection.path))
            {
                string query = "SELECT balance FROM accounts WHERE accountID = @accountID";
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accountID", accountID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetFloat(0);
                        }
                        else
                        {
                            return 0.0F;
                        }
                    }
                }
            }
        }
    }
}
