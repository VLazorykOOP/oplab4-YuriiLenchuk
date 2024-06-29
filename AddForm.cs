using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab4
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            label1.Text = "Type";
            label2.Text = "Manufacturer";
            label3.Text = "Memory";
            comboBox1.Items.Add("Graphic Adapter");
            comboBox1.Items.Add("CD Device");
            comboBox1.Items.Add("Hard Drive");
            comboBox1.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Persist Security Info=False;Integrated Security=SSPI;database = ComputerAccessories; server = (localdb)\\MSSQLLocalDB";
            using (SqlConnection connection = new(connectionString))
            {
                switch (comboBox1.SelectedIndex.ToString())
                {
                    case "0":
                        {
                            string query = "INSERT INTO GraphicAdapters (Type, Manufacturer, Memory) VALUES (@Type, @Manufacturer, @Memory)";
                            SqlCommand command = new(query, connection);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                            command.Parameters.AddWithValue("@Memory", int.Parse(txtMemory.Text));

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Data saved successfully.");
                            this.Close();
                            break;
                        }
                    case "1":
                        {
                            string query = "INSERT INTO CDDevices (Type, Manufacturer, Frequency) VALUES (@Type, @Manufacturer, @Frequency)";
                            SqlCommand command = new(query, connection);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                            command.Parameters.AddWithValue("@Frequency", int.Parse(txtMemory.Text));

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Data saved successfully.");
                            this.Close();
                            break;
                        }
                    case "2":
                        {
                            string query = "INSERT INTO HardDrives (Type, Manufacturer, Capacity) VALUES (@Type, @Manufacturer, @Capacity)";
                            SqlCommand command = new(query, connection);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                            command.Parameters.AddWithValue("@Capacity", int.Parse(txtMemory.Text));

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Data saved successfully.");
                            this.Close();
                            break;
                        }
                    default:
                        MessageBox.Show("False index");
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Type";
                    label2.Text = "Manufacturer";
                    label3.Text = "Memory";
                    break;
                case 1:
                    label1.Text = "Type";
                    label2.Text = "Manufacturer";
                    label3.Text = "Frequency";
                    break;
                case 2:
                    label1.Text = "Type";
                    label2.Text = "Manufacturer";
                    label3.Text = "Capacity";
                    break;
            }
        }
    }
}
