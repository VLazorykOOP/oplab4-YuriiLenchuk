﻿namespace lab4
{
    partial class AddForm
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
            txtType = new TextBox();
            txtManufacturer = new TextBox();
            txtMemory = new TextBox();
            btnSave = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtType
            // 
            txtType.Location = new Point(126, 45);
            txtType.Name = "txtType";
            txtType.Size = new Size(260, 27);
            txtType.TabIndex = 0;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(126, 71);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(260, 27);
            txtManufacturer.TabIndex = 1;
            // 
            // txtMemory
            // 
            txtMemory.Location = new Point(126, 97);
            txtMemory.Name = "txtMemory";
            txtMemory.Size = new Size(260, 27);
            txtMemory.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 133);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // AddForm
            // 
            ClientSize = new Size(442, 183);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnSave);
            Controls.Add(txtMemory);
            Controls.Add(txtManufacturer);
            Controls.Add(txtType);
            Name = "AddForm";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.Button btnSave;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
