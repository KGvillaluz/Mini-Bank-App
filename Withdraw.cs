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
        public static int pin;
        private readonly TransactionNew transaction;
        private readonly AccountRepository accountRepository;
        private readonly TransactionRepository transactionRepository;
        private readonly MainForm main;

        public Withdraw()
        {
            InitializeComponent();
            transaction = new TransactionNew();
            accountRepository = new AccountRepository();
            transactionRepository = new TransactionRepository();
            main = new MainForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        //private void withdrawPanel_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void wBtn_Click(object sender, EventArgs e)
        {
            

            if (checkInput(wPin.Text.Trim()) && checkInput(wConPin.Text.Trim()) && checkInput(wAmountText.Text.Trim()))
            {
                if (!wPin.Text.Equals("") && !wConPin.Text.Equals("") && !wAmountText.Text.Equals(""))
                {
                    float withdrawAmount = Convert.ToSingle(wAmountText.Text.Trim());
                    int pin_box = Convert.ToInt32(wPin.Text.Trim());
                    int con_pin = Convert.ToInt32(wConPin.Text.Trim());

                    if (withdrawAmount > 0)
                    {
                        if (withdrawAmount <= DashBoard.balance)
                        {
                            if (con_pin == pin_box)
                            {
                                if (pin_box == UserRepository.loginPin)
                                {
                                    bool isDeposit = false;

                                    if (accountRepository.updateAcc(withdrawAmount, DashBoard.accountID, isDeposit))
                                    {
                                        float newBal = accountRepository.getBalance(DashBoard.accountID, withdrawAmount);
                                        balanceWith.Text = Convert.ToString($"${newBal}");
                                        Receipt.newBalance = newBal;
                                        MessageBox.Show("Transaction Completed");
                                        TransactionNew transaction = new TransactionNew(DashBoard.accountID, withdrawAmount, "Withdraw");
                                        transactionRepository.saveTransaction(transaction);
                                        wAmountText.Text = "";
                                        wPin.Text = "";
                                        wConPin.Text = "";
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
                            else
                            {
                                MessageBox.Show("PINs you entered don't match");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insufficient Balance");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Withdraw Amount must be greater than 0");
                    }
                }
                else
                {
                    MessageBox.Show("Some fields are empty");
                }
            }
            else
            {
                MessageBox.Show("Pin/Confirm Pin should not contain characters");
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            float balance = 0.0F;
            balanceWith.Text = Convert.ToString($"${accountRepository.getBalance(DashBoard.accountID, balance)}"); //Display balance
            label4.Text = DashBoard.username;    //Display username
            label4.ForeColor = Color.DeepSkyBlue;
        }

        //Go to DashBoard
        private void button8_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();

            this.Close();
        }

        //Go to Deposit Form
        private void button5_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();

            this.Close();
        }

        //Exit to MainForm
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!");

            MainForm main = new MainForm();
            main.Show();

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool checkInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }

                return true;
            }

            return true;
        }
    }
}
