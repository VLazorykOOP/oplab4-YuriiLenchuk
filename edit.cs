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
            switch (rowName)
            {
                case "GraphicAdapter":
                    label1.Text = "Type";
                    label2.Text = "Manufacturer";
                    label3.Text = "Memory";
                    break;
                case "CDDevice":
                    label1.Text = "Type";
                    label2.Text = "Manufacturer";
                    label3.Text = "Frequency";
                    break;
                case "HardDrive":
                    label1.Text = "Type";
                    label2.Text = "Manufacturer";
                    label3.Text = "Capacity";
                    break;
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
