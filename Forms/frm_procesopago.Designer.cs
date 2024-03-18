namespace ArcorpExpress.Forms
{
    partial class frm_procesopago
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_procesopago));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_Monto = new Label();
            label4 = new Label();
            lbl_Tipo = new Label();
            label2 = new Label();
            lbl_Forma = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.Tomato;
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderThickness = 3;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(255, 192, 128);
            guna2Button1.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Properties.Resources.recibo;
            guna2Button1.ImageOffset = new Point(20, -10);
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(267, 280);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(194, 116);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "PROCESAR";
            guna2Button1.TextOffset = new Point(-10, 30);
            // 
            // guna2Button2
            // 
            guna2Button2.BorderColor = Color.Tomato;
            guna2Button2.BorderRadius = 15;
            guna2Button2.BorderThickness = 3;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(255, 192, 128);
            guna2Button2.Font = new Font("Segoe UI Black", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Image = (Image)resources.GetObject("guna2Button2.Image");
            guna2Button2.ImageOffset = new Point(20, -10);
            guna2Button2.ImageSize = new Size(40, 40);
            guna2Button2.Location = new Point(65, 280);
            guna2Button2.Margin = new Padding(3, 4, 3, 4);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(194, 116);
            guna2Button2.TabIndex = 3;
            guna2Button2.Text = "CANCELAR";
            guna2Button2.TextOffset = new Point(-10, 30);
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(120, 60);
            guna2ImageButton1.Location = new Point(3, 3);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2ImageButton1.Size = new Size(191, 67);
            guna2ImageButton1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbl_Monto, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_Tipo, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(guna2ImageButton1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_Forma, 1, 0);
            tableLayoutPanel1.Location = new Point(65, 37);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(395, 224);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // lbl_Monto
            // 
            lbl_Monto.AutoSize = true;
            lbl_Monto.Dock = DockStyle.Fill;
            lbl_Monto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Monto.Location = new Point(200, 148);
            lbl_Monto.Name = "lbl_Monto";
            lbl_Monto.Size = new Size(192, 76);
            lbl_Monto.TabIndex = 15;
            lbl_Monto.Text = "label5";
            lbl_Monto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 148);
            label4.Name = "label4";
            label4.Size = new Size(191, 76);
            label4.TabIndex = 14;
            label4.Text = "Monto a pagar:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Tipo
            // 
            lbl_Tipo.AutoSize = true;
            lbl_Tipo.Dock = DockStyle.Fill;
            lbl_Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Tipo.Location = new Point(200, 74);
            lbl_Tipo.Name = "lbl_Tipo";
            lbl_Tipo.Size = new Size(192, 74);
            lbl_Tipo.TabIndex = 13;
            lbl_Tipo.Text = "label3";
            lbl_Tipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(191, 74);
            label2.TabIndex = 12;
            label2.Text = "Tipo de Vehículo:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Forma
            // 
            lbl_Forma.AutoSize = true;
            lbl_Forma.Dock = DockStyle.Fill;
            lbl_Forma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Forma.Location = new Point(200, 0);
            lbl_Forma.Name = "lbl_Forma";
            lbl_Forma.Size = new Size(192, 74);
            lbl_Forma.TabIndex = 11;
            lbl_Forma.Text = "label1";
            lbl_Forma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_procesopago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(532, 458);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_procesopago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_procesopago";
            Paint += frm_procesopago_Paint;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_Forma;
        private Label lbl_Monto;
        private Label label4;
        private Label lbl_Tipo;
        private Label label2;
    }
}