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
        private readonly TransactionNew transaction;
        private readonly AccountRepository accountRepository;
        private readonly TransactionRepository transactionRepository;
        public Deposit()
        {
            InitializeComponent();
            transaction = new TransactionNew();
            accountRepository = new AccountRepository();
            transactionRepository = new TransactionRepository();
        }

        //Deposit Button Event
        private void wBtn_Click(object sender, EventArgs e)
        {
            if (checkInput(dPin.Text.Trim()) && checkInput(dConPin.Text.Trim()) && checkInput(dAmountText.Text.Trim()))
            {
                if (!dPin.Text.Equals("") && !dConPin.Text.Equals("") && !dAmountText.Text.Equals(""))
                {
                    int pin_box = Convert.ToInt32(dPin.Text.Trim());
                    int conP_box = Convert.ToInt32(dConPin.Text.Trim());
                    float depositAmount = Convert.ToSingle(dAmountText.Text.Trim());

                    if (depositAmount > 0)
                    {
                        if (conP_box == pin_box)
                        {
                            if (pin_box == UserRepository.loginPin)
                            {
                                bool isDeposit = true;

                                if (accountRepository.updateAcc(depositAmount, DashBoard.accountID, isDeposit))
                                {
                                    float newBal = accountRepository.getBalance(DashBoard.accountID, depositAmount);
                                    balanceDep.Text = Convert.ToString($"${newBal}");
                                    Receipt.newBalance = newBal;
                                    MessageBox.Show("Transaction Completed");
                                    TransactionNew transaction = new TransactionNew(DashBoard.accountID, depositAmount, "Deposit");
                                    transactionRepository.saveTransaction(transaction);
                                    dPin.Text = "";
                                    dConPin.Text = "";
                                    dAmountText.Text = "";
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
                        MessageBox.Show("Deposit Amount must be greater than 0");
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

        //Go to the Withdraw Form
        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();

            this.Close();
        }

        //Go to the DashBoard Form
        private void button8_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.Show();
            this.Close();
        }

        //Go Back to the MainForm
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!");

            MainForm main = new MainForm();
            main.Show();

            this.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            float balance = 0.0F;
            balanceDep.Text = Convert.ToString($"${accountRepository.getBalance(DashBoard.accountID, balance)}");  //loads the balance from dashboard
            label4.Text = DashBoard.username;
            label4.ForeColor = Color.DeepSkyBlue;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Leave(object sender, EventArgs e)
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
