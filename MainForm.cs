using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data;

namespace lab4
{
    public partial class MainForm : Form
    {
        private SqlConnection connection = new("Persist Security Info=False;Integrated Security=SSPI;database = ComputerAccessories; server = (localdb)\\MSSQLLocalDB");
        DataSet ds = new();
        SqlDataAdapter? adapter;
        private int id;
        private string? rowName;
        private string selectQuery = "select AdapterID as Id, 'GraphicAdapter' as DeviceType, Type, Manufacturer, Memory as Specification from GraphicAdapters union all select DeviceID as Id, 'CDDevice' as DeviceType, Type, Manufacturer, Frequency as Specification from CDDevices union all select DriveID as Id, 'HardDrive' as DeviceType, Type, Manufacturer, Capacity as Specification from HardDrives order by Id;";
        public MainForm()
        {
            InitializeComponent();
            connection.Open();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            render(selectQuery);
        }

        private void render(string query)
        {
            ds.Clear();
            dataGridView1.Refresh();
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new();
            addForm.ShowDialog();
            render(selectQuery);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit edit = new(id, rowName ?? "error");
            edit.ShowDialog();
            render(selectQuery);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (rowName)
            {
                case "GraphicAdapter":
                    {
                        string query = "delete from GraphicAdapters where AdapterID = @id";
                        SqlCommand command = new(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                        }
                        break;
                    }
                case "CDDevice":
                    {
                        string query = "delete from CDDevices where DeviceID = @id";
                        SqlCommand command = new(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                        }
                        break;
                    }
                case "HardDrive":
                    {
                        string query = "delete from HardDrives where DriveID = @id";
                        SqlCommand command = new(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                        }
                        break;
                    }
                default:
                    MessageBox.Show("Wrong id.");
                    break;
            }
            render(selectQuery);
        }

        private void selectedRowsButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() ?? "0");
            rowName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            selectQuery = $"with CombinedData as (select AdapterID as ID, 'GraphicAdapter' as DeviceType, Type, Manufacturer, Memory as Specification from GraphicAdapters union all select DeviceID as ID, 'CDDevice' as DeviceType, Type, Manufacturer, Frequency as Specification from CDDevices union all select DriveID as ID, 'HardDrive' as DeviceType, Type, Manufacturer, Capacity as Specification from HardDrives) select * from CombinedData where Type like '%{textBox1.Text}%' or Manufacturer like '%{textBox1.Text}%' or Specification like '%{textBox1.Text}%' or DeviceType like '%{textBox1.Text}%' order by ID;";
            render(selectQuery);
        }
    }
}
