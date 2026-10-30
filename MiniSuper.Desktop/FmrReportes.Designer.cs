namespace MiniSuper.Desktop
{
    partial class FmrReportes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            lostBorderPanel1 = new ReaLTaiizor.Controls.LostBorderPanel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            Cbreporte = new ReaLTaiizor.Controls.HopeComboBox();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            DtpInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            DtpFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DgvReportes = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new ReaLTaiizor.Controls.Panel();
            LbTotalPeriodo = new ReaLTaiizor.Controls.MoonLabel();
            foreverButton5 = new ReaLTaiizor.Controls.ForeverButton();
            lostBorderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvReportes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lostBorderPanel1
            // 
            lostBorderPanel1.BackColor = Color.FromArgb(63, 63, 70);
            lostBorderPanel1.BorderColor = Color.Azure;
            lostBorderPanel1.Controls.Add(DtpFinal);
            lostBorderPanel1.Controls.Add(foxLabel3);
            lostBorderPanel1.Controls.Add(DtpInicio);
            lostBorderPanel1.Controls.Add(foxLabel2);
            lostBorderPanel1.Controls.Add(Cbreporte);
            lostBorderPanel1.Controls.Add(foxLabel1);
            lostBorderPanel1.Controls.Add(bigLabel2);
            lostBorderPanel1.Font = new Font("Segoe UI", 12F);
            lostBorderPanel1.ForeColor = Color.White;
            lostBorderPanel1.Location = new Point(2, 12);
            lostBorderPanel1.Name = "lostBorderPanel1";
            lostBorderPanel1.Padding = new Padding(5);
            lostBorderPanel1.ShowText = false;
            lostBorderPanel1.Size = new Size(1155, 175);
            lostBorderPanel1.TabIndex = 2;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(509, 12);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(153, 46);
            bigLabel2.TabIndex = 3;
            bigLabel2.Text = "Reportes";
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foxLabel1.ForeColor = Color.White;
            foxLabel1.Location = new Point(105, 83);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(170, 35);
            foxLabel1.TabIndex = 4;
            foxLabel1.Text = "Tipo de reporte:";
            // 
            // Cbreporte
            // 
            Cbreporte.DrawMode = DrawMode.OwnerDrawFixed;
            Cbreporte.FlatStyle = FlatStyle.Flat;
            Cbreporte.Font = new Font("Segoe UI", 12F);
            Cbreporte.FormattingEnabled = true;
            Cbreporte.ItemHeight = 30;
            Cbreporte.Location = new Point(281, 82);
            Cbreporte.Name = "Cbreporte";
            Cbreporte.Size = new Size(199, 36);
            Cbreporte.TabIndex = 5;
            // 
            // foxLabel2
            // 
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foxLabel2.ForeColor = Color.White;
            foxLabel2.Location = new Point(509, 82);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(78, 35);
            foxLabel2.TabIndex = 6;
            foxLabel2.Text = "Desde:";
            // 
            // DtpInicio
            // 
            DtpInicio.Checked = true;
            DtpInicio.CustomizableEdges = customizableEdges9;
            DtpInicio.FillColor = Color.Gainsboro;
            DtpInicio.Font = new Font("Segoe UI", 9F);
            DtpInicio.Format = DateTimePickerFormat.Long;
            DtpInicio.Location = new Point(593, 83);
            DtpInicio.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DtpInicio.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DtpInicio.Name = "DtpInicio";
            DtpInicio.ShadowDecoration.CustomizableEdges = customizableEdges10;
            DtpInicio.Size = new Size(200, 36);
            DtpInicio.TabIndex = 7;
            DtpInicio.Value = new DateTime(2026, 10, 29, 18, 29, 26, 90);
            // 
            // foxLabel3
            // 
            foxLabel3.BackColor = Color.Transparent;
            foxLabel3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foxLabel3.ForeColor = Color.White;
            foxLabel3.Location = new Point(832, 84);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(78, 35);
            foxLabel3.TabIndex = 8;
            foxLabel3.Text = "Hasta:";
            // 
            // DtpFinal
            // 
            DtpFinal.Checked = true;
            DtpFinal.CustomizableEdges = customizableEdges11;
            DtpFinal.FillColor = Color.Gainsboro;
            DtpFinal.Font = new Font("Segoe UI", 9F);
            DtpFinal.Format = DateTimePickerFormat.Long;
            DtpFinal.Location = new Point(916, 82);
            DtpFinal.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DtpFinal.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DtpFinal.Name = "DtpFinal";
            DtpFinal.ShadowDecoration.CustomizableEdges = customizableEdges12;
            DtpFinal.Size = new Size(200, 36);
            DtpFinal.TabIndex = 9;
            DtpFinal.Value = new DateTime(2026, 10, 29, 18, 29, 26, 90);
            // 
            // DgvReportes
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            DgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DgvReportes.DefaultCellStyle = dataGridViewCellStyle9;
            DgvReportes.GridColor = Color.FromArgb(231, 229, 255);
            DgvReportes.Location = new Point(6, 208);
            DgvReportes.Name = "DgvReportes";
            DgvReportes.RowHeadersVisible = false;
            DgvReportes.Size = new Size(1151, 280);
            DgvReportes.TabIndex = 3;
            DgvReportes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DgvReportes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DgvReportes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvReportes.ThemeStyle.HeaderStyle.Height = 4;
            DgvReportes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DgvReportes.ThemeStyle.RowsStyle.Height = 25;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 51, 63);
            panel1.Controls.Add(foreverButton5);
            panel1.Controls.Add(LbTotalPeriodo);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(6, 519);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(1150, 162);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 4;
            panel1.Text = "panel1";
            // 
            // LbTotalPeriodo
            // 
            LbTotalPeriodo.AutoSize = true;
            LbTotalPeriodo.BackColor = Color.Transparent;
            LbTotalPeriodo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTotalPeriodo.ForeColor = Color.White;
            LbTotalPeriodo.Location = new Point(136, 72);
            LbTotalPeriodo.Name = "LbTotalPeriodo";
            LbTotalPeriodo.Size = new Size(127, 25);
            LbTotalPeriodo.TabIndex = 0;
            LbTotalPeriodo.Text = "Total periodo:";
            // 
            // foreverButton5
            // 
            foreverButton5.BackColor = Color.Transparent;
            foreverButton5.BaseColor = Color.Firebrick;
            foreverButton5.Font = new Font("Segoe UI", 12F);
            foreverButton5.Location = new Point(864, 57);
            foreverButton5.Name = "foreverButton5";
            foreverButton5.Rounded = false;
            foreverButton5.Size = new Size(120, 40);
            foreverButton5.TabIndex = 8;
            foreverButton5.Text = "Regresar";
            foreverButton5.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // FmrReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 706);
            Controls.Add(panel1);
            Controls.Add(DgvReportes);
            Controls.Add(lostBorderPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FmrReportes";
            lostBorderPanel1.ResumeLayout(false);
            lostBorderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvReportes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.LostBorderPanel lostBorderPanel1;
        private ReaLTaiizor.Controls.HopeComboBox Cbreporte;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtpFinal;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtpInicio;
        private Guna.UI2.WinForms.Guna2DataGridView DgvReportes;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.MoonLabel LbTotalPeriodo;
        private ReaLTaiizor.Controls.ForeverButton foreverButton5;
    }
}