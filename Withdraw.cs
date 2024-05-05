using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BankManagement
{
    public partial class Withdraw : Form
    {
        private int customerID;
        private float balance;
        private int pin;
        public float Balance 
        {  
            get {  return balance; }
            set {  balance = value; }
        }
        public int Pin 
        { 
            get {  return pin; } 
            set {  pin = value; }
        }
        public int CustomerID 
        { 
            get { return customerID; }
            set {  customerID = value; }
        } 

        public Withdraw()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        /*public bool updateBalance()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connstring))
                {
                    string query = "UPDATE accounts SET balance=@bal WHERE customerID=@Value;";

                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value", customerID);
                        command.Parameters.AddWithValue("@bal", balance);

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
            catch (Exception ex)
            {
                MessageBox.Show($"Error! Please try again later. {ex}");
                return false;
            }
        }*/

        private void withdrawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wBtn_Click(object sender, EventArgs e)
        {
            float withdrawAmount = Convert.ToSingle(wAmountText.Text.Trim());
            int pin = Convert.ToInt32(wAccNum.Text.Trim());

            if (withdrawAmount > 0)
            {
                if (withdrawAmount <= balance)
                {
                    if (pin == Pin)
                    {
                        try
                        {
                            Accounts a = new Accounts();
                            
                            if (a.withdraw(withdrawAmount))
                            {
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
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error! Please try again later. {ex}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Pin");
                    }
                }
            }
            else
            {
                MessageBox.Show("Insufficient Funds");
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            balanceWith.Text = Convert.ToString($"${balance}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!");

            MainForm main = new MainForm();
            main.Show();

            this.Close();
        }
    }
}
