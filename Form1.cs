using System.Data.SqlClient;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Persist Security Info=False;Integrated Security=SSPI;database = ComputerAccessories; server = (localdb)\\MSSQLLocalDB";
            using (SqlConnection connection = new(connectionString))
            {
                string query = "select * from Users";
                SqlCommand command = new(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[1].ToString() == textBox1.Text.ToString()
                            && reader[2].ToString() == textBox2.Text.ToString())
                        {
                            this.Hide();
                            MainForm mainForm = new();
                            mainForm.ShowDialog();
                            this.Close();
                        }
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sign_up signUp = new();
            signUp.ShowDialog();
            this.Show();
        }
    }
}
