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
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			pictureBox1 = new PictureBox();
			guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
			guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(21, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(226, 64);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// guna2Button1
			// 
			guna2Button1.BorderRadius = 15;
			guna2Button1.CustomizableEdges = customizableEdges1;
			guna2Button1.DisabledState.BorderColor = Color.DarkGray;
			guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
			guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			guna2Button1.FillColor = Color.DarkSeaGreen;
			guna2Button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			guna2Button1.ForeColor = Color.White;
			guna2Button1.Location = new Point(102, 469);
			guna2Button1.Name = "guna2Button1";
			guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
			guna2Button1.Size = new Size(302, 56);
			guna2Button1.TabIndex = 9;
			guna2Button1.Text = "Inicio de sesión";
			guna2Button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			guna2Button1.Tile = true;
			guna2Button1.Click += guna2Button1_Click;
			// 
			// guna2ImageButton1
			// 
			guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
			guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
			guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
			guna2ImageButton1.ImageOffset = new Point(0, 0);
			guna2ImageButton1.ImageRotate = 0F;
			guna2ImageButton1.ImageSize = new Size(30, 30);
			guna2ImageButton1.Location = new Point(469, 12);
			guna2ImageButton1.Name = "guna2ImageButton1";
			guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
			guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
			guna2ImageButton1.Size = new Size(29, 34);
			guna2ImageButton1.TabIndex = 10;
			guna2ImageButton1.Click += guna2ImageButton1_Click;
			// 
			// guna2TextBox1
			// 
			guna2TextBox1.CustomizableEdges = customizableEdges4;
			guna2TextBox1.DefaultText = "";
			guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			guna2TextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			guna2TextBox1.IconLeft = (Image)resources.GetObject("guna2TextBox1.IconLeft");
			guna2TextBox1.IconLeftOffset = new Point(5, 0);
			guna2TextBox1.IconLeftSize = new Size(32, 32);
			guna2TextBox1.Location = new Point(102, 208);
			guna2TextBox1.Margin = new Padding(5, 6, 5, 6);
			guna2TextBox1.Name = "guna2TextBox1";
			guna2TextBox1.PasswordChar = '\0';
			guna2TextBox1.PlaceholderText = "";
			guna2TextBox1.SelectedText = "";
			guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
			guna2TextBox1.Size = new Size(302, 54);
			guna2TextBox1.TabIndex = 11;
			// 
			// guna2TextBox2
			// 
			guna2TextBox2.CustomizableEdges = customizableEdges6;
			guna2TextBox2.DefaultText = "";
			guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			guna2TextBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			guna2TextBox2.IconLeft = (Image)resources.GetObject("guna2TextBox2.IconLeft");
			guna2TextBox2.IconLeftSize = new Size(40, 40);
			guna2TextBox2.Location = new Point(102, 325);
			guna2TextBox2.Margin = new Padding(5, 6, 5, 6);
			guna2TextBox2.Name = "guna2TextBox2";
			guna2TextBox2.PasswordChar = '*';
			guna2TextBox2.PlaceholderText = "";
			guna2TextBox2.SelectedText = "";
			guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges7;
			guna2TextBox2.Size = new Size(302, 54);
			guna2TextBox2.TabIndex = 12;
			// 
			// frm_inicio
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Snow;
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(510, 618);
			Controls.Add(guna2TextBox2);
			Controls.Add(guna2TextBox1);
			Controls.Add(guna2ImageButton1);
			Controls.Add(guna2Button1);
			Controls.Add(pictureBox1);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.None;
			Name = "frm_inicio";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
	}
}
