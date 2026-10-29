namespace MiniSuper.Desktop
{
    partial class FmrProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            lostBorderPanel1 = new ReaLTaiizor.Controls.LostBorderPanel();
            foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            foreverButton2 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton3 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton4 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton5 = new ReaLTaiizor.Controls.ForeverButton();
            lostBorderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(391, 19);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(378, 46);
            bigLabel2.TabIndex = 3;
            bigLabel2.Text = "Gestión de proveedores";
            bigLabel2.Click += bigLabel2_Click;
            // 
            // lostBorderPanel1
            // 
            lostBorderPanel1.BackColor = Color.FromArgb(63, 63, 70);
            lostBorderPanel1.BorderColor = Color.Azure;
            lostBorderPanel1.Controls.Add(bigLabel2);
            lostBorderPanel1.Controls.Add(foreverButton1);
            lostBorderPanel1.Controls.Add(dungeonTextBox1);
            lostBorderPanel1.Controls.Add(bigLabel1);
            lostBorderPanel1.Font = new Font("Segoe UI", 12F);
            lostBorderPanel1.ForeColor = Color.White;
            lostBorderPanel1.Location = new Point(12, 12);
            lostBorderPanel1.Name = "lostBorderPanel1";
            lostBorderPanel1.Padding = new Padding(5);
            lostBorderPanel1.ShowText = false;
            lostBorderPanel1.Size = new Size(1160, 175);
            lostBorderPanel1.TabIndex = 2;
            lostBorderPanel1.Text = "lostBorderPanel1";
            // 
            // foreverButton1
            // 
            foreverButton1.BackColor = Color.Transparent;
            foreverButton1.BaseColor = Color.FromArgb(35, 168, 109);
            foreverButton1.Font = new Font("Segoe UI", 12F);
            foreverButton1.Location = new Point(959, 97);
            foreverButton1.Name = "foreverButton1";
            foreverButton1.Rounded = false;
            foreverButton1.Size = new Size(120, 40);
            foreverButton1.TabIndex = 2;
            foreverButton1.Text = "Buscar";
            foreverButton1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Font = new Font("Tahoma", 11F);
            dungeonTextBox1.ForeColor = Color.DimGray;
            dungeonTextBox1.Location = new Point(496, 103);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(425, 28);
            dungeonTextBox1.TabIndex = 1;
            dungeonTextBox1.Text = "Ingrese el nombre o telefono del proveedor.";
            dungeonTextBox1.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(13, 94);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(476, 46);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Buscar por nombre o telefono:";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(18, 212);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(1153, 337);
            guna2DataGridView1.TabIndex = 3;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            // 
            // foreverButton2
            // 
            foreverButton2.BackColor = Color.Transparent;
            foreverButton2.BaseColor = Color.FromArgb(35, 168, 109);
            foreverButton2.Font = new Font("Segoe UI", 12F);
            foreverButton2.Location = new Point(100, 635);
            foreverButton2.Name = "foreverButton2";
            foreverButton2.Rounded = false;
            foreverButton2.Size = new Size(120, 40);
            foreverButton2.TabIndex = 4;
            foreverButton2.Text = "Agregar";
            foreverButton2.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverButton3
            // 
            foreverButton3.BackColor = Color.Transparent;
            foreverButton3.BaseColor = Color.Firebrick;
            foreverButton3.Font = new Font("Segoe UI", 12F);
            foreverButton3.Location = new Point(1035, 635);
            foreverButton3.Name = "foreverButton3";
            foreverButton3.Rounded = false;
            foreverButton3.Size = new Size(120, 40);
            foreverButton3.TabIndex = 5;
            foreverButton3.Text = "Regresar";
            foreverButton3.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverButton4
            // 
            foreverButton4.BackColor = Color.Transparent;
            foreverButton4.BaseColor = Color.FromArgb(255, 128, 128);
            foreverButton4.Font = new Font("Segoe UI", 12F);
            foreverButton4.Location = new Point(508, 635);
            foreverButton4.Name = "foreverButton4";
            foreverButton4.Rounded = false;
            foreverButton4.Size = new Size(120, 40);
            foreverButton4.TabIndex = 6;
            foreverButton4.Text = "Eliminar";
            foreverButton4.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverButton5
            // 
            foreverButton5.BackColor = Color.Transparent;
            foreverButton5.BaseColor = Color.SteelBlue;
            foreverButton5.Font = new Font("Segoe UI", 12F);
            foreverButton5.Location = new Point(294, 635);
            foreverButton5.Name = "foreverButton5";
            foreverButton5.Rounded = false;
            foreverButton5.Size = new Size(120, 40);
            foreverButton5.TabIndex = 7;
            foreverButton5.Text = "Editar";
            foreverButton5.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // FmrProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 717);
            Controls.Add(foreverButton5);
            Controls.Add(foreverButton4);
            Controls.Add(foreverButton3);
            Controls.Add(foreverButton2);
            Controls.Add(guna2DataGridView1);
            Controls.Add(lostBorderPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FmrProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmrProveedor";
            lostBorderPanel1.ResumeLayout(false);
            lostBorderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton2;
        private ReaLTaiizor.Controls.ForeverButton foreverButton3;
        private ReaLTaiizor.Controls.ForeverButton foreverButton4;
        private ReaLTaiizor.Controls.ForeverButton foreverButton5;
    }
}