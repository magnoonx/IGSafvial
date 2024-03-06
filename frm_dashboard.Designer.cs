namespace TestConexion
{
    partial class frm_dashboard
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
            btnSalir = new Button();
            btnTarjeta = new Button();
            btnLiviano = new Button();
            btnMicrobus = new Button();
            btnAutobus = new Button();
            btnC350 = new Button();
            btnC750 = new Button();
            btn3ejes = new Button();
            btn4ejes = new Button();
            btn5ejes = new Button();
            btn6ejes = new Button();
            btnCerrarBarrera = new Button();
            btnAperturarBarrera = new Button();
            btnAutAvance = new Button();
            btnSolAvance = new Button();
            btnUltimoTicket = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Location = new Point(1067, 534);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 70);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir del Canal";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnTarjeta
            // 
            btnTarjeta.Location = new Point(37, 138);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(200, 230);
            btnTarjeta.TabIndex = 1;
            btnTarjeta.Text = "TARJETA ELECTRÓNICA [NUM 0]";
            btnTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnLiviano
            // 
            btnLiviano.Location = new Point(243, 138);
            btnLiviano.Name = "btnLiviano";
            btnLiviano.Size = new Size(200, 230);
            btnLiviano.TabIndex = 2;
            btnLiviano.Text = "LIVIANO [NUM 1]";
            btnLiviano.UseVisualStyleBackColor = true;
            // 
            // btnMicrobus
            // 
            btnMicrobus.Location = new Point(449, 138);
            btnMicrobus.Name = "btnMicrobus";
            btnMicrobus.Size = new Size(200, 230);
            btnMicrobus.TabIndex = 3;
            btnMicrobus.Text = "MICROBUS [NUM 2]";
            btnMicrobus.UseVisualStyleBackColor = true;
            // 
            // btnAutobus
            // 
            btnAutobus.Location = new Point(655, 138);
            btnAutobus.Name = "btnAutobus";
            btnAutobus.Size = new Size(200, 230);
            btnAutobus.TabIndex = 4;
            btnAutobus.Text = "AUTOBUS [NUM 3]";
            btnAutobus.UseVisualStyleBackColor = true;
            // 
            // btnC350
            // 
            btnC350.Location = new Point(861, 138);
            btnC350.Name = "btnC350";
            btnC350.Size = new Size(200, 230);
            btnC350.TabIndex = 5;
            btnC350.Text = "CAMIÓN 350 [NUM 4]";
            btnC350.UseVisualStyleBackColor = true;
            // 
            // btnC750
            // 
            btnC750.Location = new Point(37, 374);
            btnC750.Name = "btnC750";
            btnC750.Size = new Size(200, 230);
            btnC750.TabIndex = 6;
            btnC750.Text = "CAMIÓN 750";
            btnC750.UseVisualStyleBackColor = true;
            // 
            // btn3ejes
            // 
            btn3ejes.Location = new Point(243, 374);
            btn3ejes.Name = "btn3ejes";
            btn3ejes.Size = new Size(200, 230);
            btn3ejes.TabIndex = 7;
            btn3ejes.Text = "3 EJES [NUM 6]";
            btn3ejes.UseVisualStyleBackColor = true;
            // 
            // btn4ejes
            // 
            btn4ejes.Location = new Point(449, 374);
            btn4ejes.Name = "btn4ejes";
            btn4ejes.Size = new Size(200, 230);
            btn4ejes.TabIndex = 8;
            btn4ejes.Text = "4 EJES [NUM 7]";
            btn4ejes.UseVisualStyleBackColor = true;
            // 
            // btn5ejes
            // 
            btn5ejes.Location = new Point(655, 374);
            btn5ejes.Name = "btn5ejes";
            btn5ejes.Size = new Size(200, 230);
            btn5ejes.TabIndex = 9;
            btn5ejes.Text = "5 EJES [NUM 8]";
            btn5ejes.UseVisualStyleBackColor = true;
            // 
            // btn6ejes
            // 
            btn6ejes.Location = new Point(861, 374);
            btn6ejes.Name = "btn6ejes";
            btn6ejes.Size = new Size(200, 230);
            btn6ejes.TabIndex = 10;
            btn6ejes.Text = "6 EJES [NUM 9]";
            btn6ejes.UseVisualStyleBackColor = true;
            // 
            // btnCerrarBarrera
            // 
            btnCerrarBarrera.Location = new Point(1067, 454);
            btnCerrarBarrera.Name = "btnCerrarBarrera";
            btnCerrarBarrera.Size = new Size(200, 70);
            btnCerrarBarrera.TabIndex = 11;
            btnCerrarBarrera.Text = "CERRAR BARRERA";
            btnCerrarBarrera.UseVisualStyleBackColor = true;
            btnCerrarBarrera.Click += btnCerrarBarrera_Click;
            // 
            // btnAperturarBarrera
            // 
            btnAperturarBarrera.Location = new Point(1067, 374);
            btnAperturarBarrera.Name = "btnAperturarBarrera";
            btnAperturarBarrera.Size = new Size(200, 70);
            btnAperturarBarrera.TabIndex = 12;
            btnAperturarBarrera.Text = "APERTURAR BARRERA";
            btnAperturarBarrera.UseVisualStyleBackColor = true;
            // 
            // btnAutAvance
            // 
            btnAutAvance.Location = new Point(1067, 298);
            btnAutAvance.Name = "btnAutAvance";
            btnAutAvance.Size = new Size(200, 70);
            btnAutAvance.TabIndex = 13;
            btnAutAvance.Text = "AUTORIZAR AVANCE [R]";
            btnAutAvance.UseVisualStyleBackColor = true;
            // 
            // btnSolAvance
            // 
            btnSolAvance.Location = new Point(1067, 218);
            btnSolAvance.Name = "btnSolAvance";
            btnSolAvance.Size = new Size(200, 70);
            btnSolAvance.TabIndex = 14;
            btnSolAvance.Text = "SOLICITAR AVANCE [L]";
            btnSolAvance.UseVisualStyleBackColor = true;
            // 
            // btnUltimoTicket
            // 
            btnUltimoTicket.Location = new Point(1067, 138);
            btnUltimoTicket.Name = "btnUltimoTicket";
            btnUltimoTicket.Size = new Size(200, 70);
            btnUltimoTicket.TabIndex = 15;
            btnUltimoTicket.Text = "ÚLTIMO TICKET";
            btnUltimoTicket.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(274, 81);
            label1.TabIndex = 16;
            label1.Text = "SAFVIAL";
            // 
            // frm_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 739);
            Controls.Add(label1);
            Controls.Add(btnUltimoTicket);
            Controls.Add(btnSolAvance);
            Controls.Add(btnAutAvance);
            Controls.Add(btnAperturarBarrera);
            Controls.Add(btnCerrarBarrera);
            Controls.Add(btn6ejes);
            Controls.Add(btn5ejes);
            Controls.Add(btn4ejes);
            Controls.Add(btn3ejes);
            Controls.Add(btnC750);
            Controls.Add(btnC350);
            Controls.Add(btnAutobus);
            Controls.Add(btnMicrobus);
            Controls.Add(btnLiviano);
            Controls.Add(btnTarjeta);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_dashboard";
            Text = "frm_dashboard";
            Load += frm_dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnTarjeta;
        private Button btnLiviano;
        private Button btnMicrobus;
        private Button btnAutobus;
        private Button btnC350;
        private Button btnC750;
        private Button btn3ejes;
        private Button btn4ejes;
        private Button btn5ejes;
        private Button btn6ejes;
        private Button btnCerrarBarrera;
        private Button btnAperturarBarrera;
        private Button btnAutAvance;
        private Button btnSolAvance;
        private Button btnUltimoTicket;
        private Label label1;
    }
}