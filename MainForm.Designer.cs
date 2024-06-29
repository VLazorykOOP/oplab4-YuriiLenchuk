using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab4
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnEdit = new Button();
            btnOrder = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(482, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(563, 396);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 27);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(644, 396);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 27);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Delete";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 377);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += selectedRowsButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // MainForm
            // 
            ClientSize = new Size(731, 435);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnOrder);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "MainForm";
            Text = "Computer Accessories";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOrder;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}
