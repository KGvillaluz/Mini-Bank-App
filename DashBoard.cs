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
using Org.BouncyCastle.Asn1.Ocsp;

namespace BankManagement
{
    public partial class DashBoard : Form
    {
        string connstring = "Data Source=C:\\Users\\kians\\atm.db;Version=3";

        private int customerID;
        private float balance;
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public float Bal { 
            get { return  balance; }
            set {  balance = value; }
        }

        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            balanceINT.Text = Convert.ToString($"${updateBalance(customerID)}");
            loadDashBoard();
        }

        public void loadDashBoard()
        {
            

            using (SQLiteConnection connection = new SQLiteConnection(connstring))
            {
                string query = "SELECT * FROM transactions";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    dataGridView1.DataSource = dataTable;
                }
            }

            columnsColor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Click(object sender, EventArgs e)
        {

        }

        public void columnsColor()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!");

            MainForm main = new MainForm();
            main.Show();

            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();

            this.Close();
        }

        public static float updateBalance(int cusID)
        {
            string connstring = "Data Source=C:\\Users\\kians\\atm.db;Version=3";

            using (SQLiteConnection connection = new SQLiteConnection(connstring))
            {
                connection.Open();

                string select = "SELECT balance FROM accounts WHERE customerID=@CustomerID";

                using (SQLiteCommand command = new SQLiteCommand(select, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", cusID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            float sqlBalance = Convert.ToSingle(reader.GetOrdinal("balance"));
                            return sqlBalance;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
