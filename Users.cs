using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BankManagement
{
    internal class Users
    {
        string firstName, lastName, email;
        int pin, conpin, customerID;
        int logCusID, logPin;

        public Users(string firstName, string lastName, string email, int pin, int conpin, int customerID) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.pin = pin;
            this.conpin = conpin;
            this.customerID = customerID;
        }

        public Users(int logCusID, int logPin)
        {
            this.logCusID = logCusID;
            this.logPin = logPin;
        }

        public bool saveData()
        {
            string userName = firstName + " " + lastName;
            string connection = "Data Source=C:\\Users\\kians\\atm.db;Version=3";

            using (SQLiteConnection connstring = new SQLiteConnection(connection))
            {
                try
                {
                    connstring.Open();

                    string insert = "INSERT INTO users (customerID, username, email, pin) VALUES (@Value1, @Value2, @Value3, @Value4);";

                    using (SQLiteCommand command = new SQLiteCommand(insert, connstring))
                    {
                        command.Parameters.AddWithValue("@Value1", customerID);
                        command.Parameters.AddWithValue("@Value2", userName);
                        command.Parameters.AddWithValue("@Value3", email);
                        command.Parameters.AddWithValue("@Value4", pin);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            Accounts accounts = new Accounts();
                            accounts.CustomerID = customerID;
                            accounts.createAcc();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("MMMMMMMMMMMMMMM");
                            return false;
                        }
                    }

                    connstring.Close();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        

        public bool isLogin()
        {
            string connstring = "Data Source=C:\\Users\\kians\\atm.db;Version=3";

            using (SQLiteConnection connection = new SQLiteConnection(connstring))
            {
                try
                {
                    string select = "SELECT pin FROM users WHERE customerID = @CustomerID";

                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(select, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", logCusID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int dataAccountID = reader.GetInt32(reader.GetOrdinal("pin"));

                                if (dataAccountID == logPin)
                                {
                                    Accounts.cusID = logCusID;
                                    
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    return false;
                }
            }
        }
    }
}
