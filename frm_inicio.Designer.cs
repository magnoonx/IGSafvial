namespace TestConexion
{
    partial class frm_inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnIniciarSesion = new Guna.UI2.WinForms.Guna2CircleButton();
            btnSalirSistema = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(25, 167);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(243, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(25, 238);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(243, 27);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 126);
            label1.Name = "label1";
            label1.Size = new Size(197, 38);
            label1.TabIndex = 3;
            label1.Text = "Usuario / DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 197);
            label2.Name = "label2";
            label2.Size = new Size(164, 38);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.DisabledState.BorderColor = Color.DarkGray;
            btnIniciarSesion.DisabledState.CustomBorderColor = Color.DarkGray;
            btnIniciarSesion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnIniciarSesion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnIniciarSesion.FillColor = Color.Green;
            btnIniciarSesion.Font = new Font("Segoe UI", 9F);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(25, 279);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnIniciarSesion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnIniciarSesion.Size = new Size(117, 113);
            btnIniciarSesion.TabIndex = 7;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnSalirSistema
            // 
            btnSalirSistema.DisabledState.BorderColor = Color.DarkGray;
            btnSalirSistema.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalirSistema.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalirSistema.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalirSistema.FillColor = Color.DarkOrange;
            btnSalirSistema.Font = new Font("Segoe UI", 9F);
            btnSalirSistema.ForeColor = Color.White;
            btnSalirSistema.Location = new Point(151, 279);
            btnSalirSistema.Name = "btnSalirSistema";
            btnSalirSistema.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalirSistema.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnSalirSistema.Size = new Size(117, 113);
            btnSalirSistema.TabIndex = 8;
            btnSalirSistema.Text = "Salir";
            btnSalirSistema.Click += btnSalirSistema_Click;
            // 
            // frm_inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(296, 428);
            Controls.Add(btnSalirSistema);
            Controls.Add(btnIniciarSesion);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_inicio";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2CircleButton btnSalirSistema;
    }
}
