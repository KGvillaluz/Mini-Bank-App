using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BankManagement
{
    internal class Accounts
    {
        public int accountID = generateAccID();
        public float balance;
        private int customerID;
        string connstring = "Data Source=C:\\Users\\kians\\atm.db;Version=3";

        public static int cusID;

        public int CustomerID 
        { 
            get {  return customerID; }
            set { customerID = value; }
        }

        public void createAcc()
        {
            balance = 0.00F;

            using (SQLiteConnection connection = new SQLiteConnection(connstring))
            {
                string insert = "INSERT INTO accounts (accountID, customerID, balance) VALUES (@Value1, @Value2, @Value3);";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(insert, connection))
                {
                    command.Parameters.AddWithValue("@Value1", accountID);
                    command.Parameters.AddWithValue("@Value2", customerID);
                    command.Parameters.AddWithValue("@Value3", balance);

                    command.ExecuteNonQuery();
                }
            }
            Deposit deposit = new Deposit();
            deposit.Balance = balance;

            DashBoard dashboard = new DashBoard();
            dashboard.CustomerID = customerID;
            dashboard.Bal = balance;   

            Transaction t = new Transaction();
            t.AccountID = accountID;

            Withdraw w = new Withdraw();
            w.Balance = balance;

        }

        public bool withdraw(float withdrawAmount)
        {
            balance -= withdrawAmount;

            using (SQLiteConnection connection = new SQLiteConnection(connstring))
            {
                string query = "UPDATE accounts SET balance = balance - @balance WHERE customerID = @customerID";

                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@balance", balance);
                    command.Parameters.AddWithValue("@customerID", cusID);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        DashBoard.updateBalance(cusID);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool deposit(float depositAmount)
        {
            float sqlBalance = 0F;

            

            using (SQLiteConnection connection = new SQLiteConnection(connstring))
            {
                string update = "UPDATE accounts SET balance = balance + @Balance WHERE customerID = @CustomerID";

                connection.Open();

                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(update, connection))
                    {
                        command.Parameters.AddWithValue("@Balance", depositAmount);
                        command.Parameters.AddWithValue("@CustomerID", cusID);
                        var result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public static int generateAccID()
        {
            Random rand = new Random();
            int num = rand.Next(1000, 3000);

            return num;
        }

        public float getDepositBalance(float balance)
        {
            

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connstring))
                {
                    connection.Open();

                    string insertQuery = "SELECT balance FROM accounts WHERE customerID=@CustomerID";

                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", cusID);
                        object result = command.ExecuteNonQuery();

                        if (result != null)
                        {
                            balance = Convert.ToSingle(result);
                        }
                        else
                        {
                            balance = 0;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return balance;
        }
    }
}
