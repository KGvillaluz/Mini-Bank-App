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
    public partial class SignupForm : Form
    {
        public static int accountID;
        public SignupForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //Sign up Button Event
        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (fNameBox.Text.Equals("") || lNameBox.Text.Equals("") || emailBox.Text.Equals("") || pinBox.Text.Equals("") || conPinBox.Text.Equals(""))
            {
                MessageBox.Show("Please fill up the form");
            }
            else
            {
                string firstName = fNameBox.Text.Trim();
                string lastName = lNameBox.Text.Trim();
                string email = emailBox.Text.Trim();

                if (email.Length < 10)
                {
                    MessageBox.Show("Your Email must be not below 10 characters");
                }
                else
                {
                    if (checkInput(pinBox.Text.Trim()) && checkInput(conPinBox.Text.Trim()))
                    {
                        int pin = Convert.ToInt32(pinBox.Text.Trim());
                        int con_pin = Convert.ToInt32(conPinBox.Text.Trim());

                        if (pinBox.Text.Length <= 5)
                        {
                            MessageBox.Show("Your Pin must not below 6 numbers");
                        }
                        else
                        {
                            if (pin == con_pin)
                            {
                                UsersNew users = new UsersNew(firstName, lastName, email, pin, con_pin);
                                UsersService usersService = new UsersService();

                                if (!usersService.signup(users))
                                {
                                    MessageBox.Show("Error! Please try again later");
                                }
                                else
                                {
                                    MessageBox.Show($"-----Your Information-----\n\nAccount ID No : {accountID}\nPin                : {pin}\n\n--------------------------------");

                                    MainForm mainForm = new MainForm();
                                    mainForm.Show();

                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your Confirmation Pin did not match your Pin");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pin/Confirm Pin should not contain characters");
                    }
                }
                
            }
        }

        static int generateID()
        {
            Random rnd = new Random();
            int num = rnd.Next(1000, 5000);

            return num;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void fNameBox_TextChanged(object sender, EventArgs e)
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