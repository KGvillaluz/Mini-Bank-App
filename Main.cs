using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();

            this.Hide();    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pinNumber.Text.Trim().Length == 0 || accountID.Text.Trim().Length == 0)
            {
                MessageBox.Show("fill the empty field");
            }
            else
            {
                int accID = Convert.ToInt32(accountID.Text.Trim());
                int pin = Convert.ToInt32(pinNumber.Text.Trim());

                Users user = new Users(accID, pin);
                bool isLogin = user.isLogin();

                if (isLogin)
                {
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Can't find your account");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!");

            this.Close();
        }
    }
}
