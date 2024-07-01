using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab4
{
    public partial class edit : Form
    {
        private readonly string rowName;
        private readonly int id;
        public edit(int id, string rowName)
        {
            this.rowName = rowName;
            this.id = id;
            InitializeComponent();
            string connectionString = "Persist Security Info=False;Integrated Security=SSPI;database = ComputerAccessories; server = (localdb)\\MSSQLLocalDB";
            using (SqlConnection connection = new(connectionString))
            {
                switch (rowName)
                {
                    case "GraphicAdapter":
                        {
                            label1.Text = "Type";
                            label2.Text = "Manufacturer";
                            label3.Text = "Memory";
                            connection.Open();
                            string select = $"select Type, Manufacturer, Memory from GraphicAdapters where AdapterId = {id}";
                            SqlCommand selectComm = new(select, connection);
                            using (SqlDataReader reader = selectComm.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    txtType.Text = reader[0].ToString();
                                    txtManufacturer.Text = reader[1].ToString();
                                    txtMemory.Text = reader[2].ToString();
                                }
                            }
                            connection.Close();
                            break;
                        }
                    case "CDDevice":
                        {
                            label1.Text = "Type";
                            label2.Text = "Manufacturer";
                            label3.Text = "Frequency";
                            connection.Open();
                            string select = $"select Type, Manufacturer, Frequency from CDDevices where DeviceId = {id}";
                            SqlCommand selectComm = new(select, connection);
                            using (SqlDataReader reader = selectComm.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    txtType.Text = reader[0].ToString();
                                    txtManufacturer.Text = reader[1].ToString();
                                    txtMemory.Text = reader[2].ToString();
                                }
                            }
                            connection.Close();
                            break;
                        }
                    case "HardDrive":
                        {
                            label1.Text = "Type";
                            label2.Text = "Manufacturer";
                            label3.Text = "Capacity";
                            connection.Open();
                            string select = $"select Type, Manufacturer, Capacity from HardDrives where DriveId = {id}";
                            SqlCommand selectComm = new(select, connection);
                            using (SqlDataReader reader = selectComm.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    txtType.Text = reader[0].ToString();
                                    txtManufacturer.Text = reader[1].ToString();
                                    txtMemory.Text = reader[2].ToString();
                                }
                            }
                            connection.Close();
                            break;
                        }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Persist Security Info=False;Integrated Security=SSPI;database = ComputerAccessories; server = (localdb)\\MSSQLLocalDB";
            using (SqlConnection connection = new(connectionString))
            {
                switch (rowName)
                {
                    case "GraphicAdapter":
                        {
                            string query = "update GraphicAdapters set Type = @Type, Manufacturer = @Manufacturer, Memory = @Memory where AdapterId = @id;";
                            SqlCommand command = new(query, connection);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                            command.Parameters.AddWithValue("@Memory", int.Parse(txtMemory.Text));
                            command.Parameters.AddWithValue("@id", id);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Data saved successfully.");
                            this.Close();
                            break;
                        }
                    case "CDDevice":
                        {
                            string query = "update CDDevices set Type = @Type, Manufacturer = @Manufacturer, Frequency = @Frequency where DeviceID = @id;";
                            SqlCommand command = new(query, connection);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                            command.Parameters.AddWithValue("@Frequency", int.Parse(txtMemory.Text));
                            command.Parameters.AddWithValue("@id", id);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Data saved successfully.");
                            this.Close();
                            break;
                        }
                    case "HardDrive":
                        {
                            string query = "update HardDrives set Type = @Type, Manufacturer = @Manufacturer, Capacity = @Capacity where DriveID = @id;";
                            SqlCommand command = new(query, connection);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                            command.Parameters.AddWithValue("@Capacity", int.Parse(txtMemory.Text));
                            command.Parameters.AddWithValue("@id", id);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Data saved successfully.");
                            this.Close();
                            break;
                        }
                    default:
                        MessageBox.Show(rowName);
                        break;
                }
            }
        }
    }
}
