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
    public partial class DashBoard : Form
    {
        string connstring = Connection.path;

        public static float balance;
        public static string username;
        public static int accountID;
        MainForm main = new MainForm();

        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            label1.Text = getUserName(accountID);
            username = label1.Text.Trim();
            loadDashBoard();

            Receipt.userName = username;
            Receipt.currentBalance = balance;
        }

        public void loadDashBoard()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connstring))
            {
                connection.Open();

                string query = "SELECT * FROM transactions WHERE accountID=@accountID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accountID", accountID);

                    DataTable dataTable = new DataTable();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                }

                string select = "SELECT balance FROM accounts WHERE accountID=@accountID";

                using (SQLiteCommand command = new SQLiteCommand(select,connection))
                {
                    

                    command.Parameters.AddWithValue("@accountID", accountID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            balance = Convert.ToSingle(reader["balance"]);

                            balanceINT.Text = Convert.ToString($"${balance}");
                        }
                    }
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

        public string getUserName(int accountID)
        {

            using (SQLiteConnection connection = new SQLiteConnection(connstring))
            {
                connection.Open();

                string query = "SELECT username FROM users WHERE accountID=@accountID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accountID", accountID);

                    using (SQLiteDataReader rdr = command.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            string username = rdr.GetString(rdr.GetOrdinal("username"));
                            Receipt.userName = username;
                            Receipt.accountID = accountID;
                            return username;
                        }
                        else
                        {
                            return "username";
                        }
                    }
                }
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.SteelBlue;
            button3.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.SteelBlue;
            button2.ForeColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.MidnightBlue;
            button3.ForeColor = Color.DeepSkyBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.MidnightBlue;
            button2.ForeColor = Color.DeepSkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MidnightBlue;
            button1.ForeColor = Color.DeepSkyBlue;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
