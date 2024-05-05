using MySql.Data.MySqlClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = fNameBox.Text.Trim();
            string lastName = lNameBox.Text.Trim();
            string email = emailBox.Text.Trim();
            int pin = Convert.ToInt32(pinBox.Text.Trim());
            int con_pin = Convert.ToInt32(conPinBox.Text.Trim());
            int customerID = generateID();

            if (fNameBox.Text.Trim() == "" || lNameBox.Text.Trim() == "" || emailBox.Text.Trim() == "" || pinBox.Text.Trim() == "" || conPinBox.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up the form");
            }
            else
            {

                if (email.Length < 10)
                {
                    MessageBox.Show("Your Email must be not below 10 characters");
                }
                else
                {
                    if (pin.ToString().Length <= 5) 
                    {
                        MessageBox.Show("Your Pin must not below 6 numbers");
                    }
                    else
                    {
                        if (pin == con_pin)
                        {
                            Users users = new Users(firstName, lastName, email, pin, con_pin, customerID);

                            if (!users.saveData())
                            {
                                MessageBox.Show("Error! Please try again later");
                            }
                            else
                            {
                                MessageBox.Show($"-----Your Information-----\n\nCustomerID : {customerID}\nPin                : {pin}\n\n--------------------------------");

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
                
            }
        }

        static int generateID()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 500);

            return num;
        }
    }
}
