using System.Data.SqlClient;

namespace lab4
{
    public partial class sign_up : Form
    {
        public sign_up()
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
                string query = "INSERT INTO Users(Login, Password) VALUES (@Login, @Password);";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Login", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@Password", textBox2.Text.ToString());
                connection.Open();

                command.ExecuteNonQuery();
                MessageBox.Show("You registered successfully.");
                connection.Close();
                this.Close();
            }
        }
    }
}
