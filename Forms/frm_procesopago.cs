using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcorpExpress.Forms
{
    public partial class frm_procesopago : Form
    {
        public frm_procesopago(string varTipo, string varMonto, string varForma)
        {
            InitializeComponent();
            this.lbl_Forma.Text = varForma;
            this.lbl_Monto.Text = varMonto.ToString();
            this.lbl_Tipo.Text = varTipo;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int cornerRadius = 20; // Puedes ajustar este valor para cambiar el radio de los bordes redondeados

            gp.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            gp.AddArc(this.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            gp.AddArc(this.Width - cornerRadius * 2, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            gp.AddArc(0, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);

            this.Region = new System.Drawing.Region(gp);
        }
        private void frm_procesopago_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2); // Define un lápiz negro con un grosor de 2

            int borderWidth = 10; // Ancho del borde

            // Dibuja el borde izquierdo
            g.DrawLine(pen, 0, 0, 0, this.Height);

            // Dibuja el borde derecho
            g.DrawLine(pen, this.Width - borderWidth, 0, this.Width - borderWidth, this.Height);

            // Dibuja el borde superior
            g.DrawLine(pen, 0, 0, this.Width, 0);

            // Dibuja el borde inferior
            g.DrawLine(pen, 0, this.Height - borderWidth, this.Width, this.Height - borderWidth);
        }
    }
}
    
