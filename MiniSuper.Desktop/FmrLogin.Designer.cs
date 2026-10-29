namespace MiniSuper.Desktop
{
    partial class FmrLogin
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
            PanelLogin = new ReaLTaiizor.Controls.LostBorderPanel();
            LbNombreUsuario = new ReaLTaiizor.Controls.DungeonLabel();
            LbClaveUsuario = new ReaLTaiizor.Controls.DungeonLabel();
            TxtNombreUsuario = new ReaLTaiizor.Controls.FoxTextBox();
            TxtClaveUsuario = new ReaLTaiizor.Controls.FoxTextBox();
            aloneButton1 = new ReaLTaiizor.Controls.AloneButton();
            PanelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLogin
            // 
            PanelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelLogin.BackColor = Color.LightSteelBlue;
            PanelLogin.BorderColor = Color.DeepSkyBlue;
            PanelLogin.Controls.Add(aloneButton1);
            PanelLogin.Controls.Add(TxtClaveUsuario);
            PanelLogin.Controls.Add(TxtNombreUsuario);
            PanelLogin.Controls.Add(LbClaveUsuario);
            PanelLogin.Controls.Add(LbNombreUsuario);
            PanelLogin.Font = new Font("Segoe UI", 12F);
            PanelLogin.ForeColor = Color.Black;
            PanelLogin.Location = new Point(91, 55);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Padding = new Padding(5);
            PanelLogin.ShowText = true;
            PanelLogin.Size = new Size(958, 594);
            PanelLogin.TabIndex = 0;
            PanelLogin.Text = "Inicio de Sesión:";
            // 
            // LbNombreUsuario
            // 
            LbNombreUsuario.AutoSize = true;
            LbNombreUsuario.BackColor = Color.Transparent;
            LbNombreUsuario.Font = new Font("Segoe UI", 11F);
            LbNombreUsuario.ForeColor = Color.Black;
            LbNombreUsuario.Location = new Point(252, 200);
            LbNombreUsuario.Name = "LbNombreUsuario";
            LbNombreUsuario.Size = new Size(140, 20);
            LbNombreUsuario.TabIndex = 0;
            LbNombreUsuario.Text = "Nombre de usuario:";
            // 
            // LbClaveUsuario
            // 
            LbClaveUsuario.AutoSize = true;
            LbClaveUsuario.BackColor = Color.Transparent;
            LbClaveUsuario.Font = new Font("Segoe UI", 11F);
            LbClaveUsuario.ForeColor = Color.Black;
            LbClaveUsuario.Location = new Point(252, 295);
            LbClaveUsuario.Name = "LbClaveUsuario";
            LbClaveUsuario.Size = new Size(140, 20);
            LbClaveUsuario.TabIndex = 1;
            LbClaveUsuario.Text = "Nombre de usuario:";
            // 
            // TxtNombreUsuario
            // 
            TxtNombreUsuario.BackColor = Color.Transparent;
            TxtNombreUsuario.EnabledCalc = true;
            TxtNombreUsuario.Font = new Font("Segoe UI", 10F);
            TxtNombreUsuario.ForeColor = Color.FromArgb(66, 78, 90);
            TxtNombreUsuario.Location = new Point(409, 183);
            TxtNombreUsuario.MaxLength = 32767;
            TxtNombreUsuario.MultiLine = false;
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.ReadOnly = true;
            TxtNombreUsuario.Size = new Size(269, 54);
            TxtNombreUsuario.TabIndex = 2;
            TxtNombreUsuario.Text = "Ingrese su nombre de usuario.";
            TxtNombreUsuario.TextAlign = HorizontalAlignment.Center;
            TxtNombreUsuario.UseSystemPasswordChar = false;
            // 
            // TxtClaveUsuario
            // 
            TxtClaveUsuario.BackColor = Color.Transparent;
            TxtClaveUsuario.EnabledCalc = true;
            TxtClaveUsuario.Font = new Font("Segoe UI", 10F);
            TxtClaveUsuario.ForeColor = Color.FromArgb(66, 78, 90);
            TxtClaveUsuario.Location = new Point(409, 278);
            TxtClaveUsuario.MaxLength = 32767;
            TxtClaveUsuario.MultiLine = false;
            TxtClaveUsuario.Name = "TxtClaveUsuario";
            TxtClaveUsuario.ReadOnly = true;
            TxtClaveUsuario.Size = new Size(269, 54);
            TxtClaveUsuario.TabIndex = 3;
            TxtClaveUsuario.Text = "Ingrese su clave.";
            TxtClaveUsuario.TextAlign = HorizontalAlignment.Center;
            TxtClaveUsuario.UseSystemPasswordChar = false;
            // 
            // aloneButton1
            // 
            aloneButton1.BackColor = Color.Transparent;
            aloneButton1.EnabledCalc = true;
            aloneButton1.Font = new Font("Segoe UI", 9F);
            aloneButton1.ForeColor = Color.Black;
            aloneButton1.Location = new Point(409, 445);
            aloneButton1.Name = "aloneButton1";
            aloneButton1.Size = new Size(120, 40);
            aloneButton1.TabIndex = 4;
            aloneButton1.Text = "Ingresar";
            // 
            // FmrLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1144, 706);
            Controls.Add(PanelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FmrLogin";
            StartPosition = FormStartPosition.CenterScreen;
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.LostBorderPanel PanelLogin;
        private ReaLTaiizor.Controls.DungeonLabel LbClaveUsuario;
        private ReaLTaiizor.Controls.DungeonLabel LbNombreUsuario;
        private ReaLTaiizor.Controls.FoxTextBox TxtClaveUsuario;
        private ReaLTaiizor.Controls.FoxTextBox TxtNombreUsuario;
        private ReaLTaiizor.Controls.AloneButton aloneButton1;
    }
}