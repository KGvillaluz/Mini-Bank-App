using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class Deposit : Form
    {
        private float balance;
        private int pin;
        private int customerID;

       
        public float Balance 
        { 
            get {  return balance; }
            set {  balance = value; }
        }
        public int Pin 
        {
            get { return  pin; }
            set {  pin = value; }
        }
        public int CustomerID 
        { 
            get { return  customerID; }
            set {  customerID = value; }
        }

        public Deposit(int customerID, int pin)
        {
            CustomerID = customerID;
            Pin = pin;
        }

        public Deposit()
        {
            InitializeComponent();
        }

        /*public bool updateBalance()
        {
            try
            {
                if (checkID())
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connstring))
                    {

                        string query = "UPDATE accounts SET balance = @balance WHERE customerID = @customerID";


                        connection.Open();

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@balance", balance);
                            command.Parameters.AddWithValue("@customerID", customerID);

                            command.ExecuteNonQuery();
                            return true;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Cant update balance");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! Please try again later. {ex}");
                return false;
            }
        }

        bool checkID()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connstring))
                {
                    string query = "SELECT customerID FROM accounts WHERE customerID = @customerID";

                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerID", customerID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            int cID = Convert.ToInt32(reader.GetOrdinal("customerID"));

                            return cID == customerID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"cant find customerID {ex}");
                return false;
            }
        }*/

        private void wBtn_Click(object sender, EventArgs e)
        {
            int pin_box = Convert.ToInt32(dPin.Text.Trim());
            int conP_box = Convert.ToInt32(dConPin.Text.Trim());
            float depositAmount = Convert.ToSingle(dAmountText.Text.Trim());
            Accounts a = new Accounts();

            if (conP_box == pin_box)
            {
                if (depositAmount != 0)
                {
                    a.deposit(depositAmount);
                    //balanceDep.Text = Convert.ToString(a.getDepositBalance(depositAmount));
                    MessageBox.Show("Transaction Completed");
                    DashBoard d = new DashBoard();
                    d.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Pin");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();

            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!");

            MainForm main = new MainForm();
            main.Show();

            this.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            //float depositAmount = Convert.ToSingle(dAmountText.Text.Trim());

            //Accounts a = new Accounts();
            //balanceDep.Text = Convert.ToString(a.getDepositBalance(depositAmount));
        }

        
    }
}
