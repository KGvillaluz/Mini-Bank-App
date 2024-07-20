using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class UserRepository
    {
        public static int loginPin;
        private int _accountID;
        public bool saveUser(UsersNew user)
        {
            Random rand = new Random();
            _accountID = rand.Next(1000, 5000);
            string username = user.FirstName + " " + user.LastName;

            using (SQLiteConnection connection = new SQLiteConnection(Connection.path))
            {
                connection.Open();
                string insert = "INSERT INTO users (accountID, username, email, pin) VALUES (@accountID, @username, @email, @pin);";

                using (SQLiteCommand command = new  SQLiteCommand(insert, connection))
                {
                    command.Parameters.AddWithValue("@accountID", _accountID);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@pin", user.Pin);
                    
                    if (command.ExecuteNonQuery() > 0)
                    {
                        AccountsNew.AccountID = _accountID;
                        SignupForm.accountID = _accountID;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        public bool isLogin(int logAccID, int logPin)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Connection.path))
            {
                connection.Open();
                string select = "SELECT pin FROM users WHERE accountID = @AccountID";

                using (SQLiteCommand command = new SQLiteCommand(select, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", logAccID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int databasePin = reader.GetInt32(reader.GetOrdinal("pin"));
                            loginPin = databasePin;
                            return databasePin == logPin;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

    }
}
