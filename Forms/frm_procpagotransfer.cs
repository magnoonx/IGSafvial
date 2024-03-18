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
    public partial class frm_procpagotransfer : Form
    {
        public frm_procpagotransfer(string varTipo, string varMonto, string varForma)
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

       

        private void frm_procpagotransfer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2); // Define un lápiz negro con un grosor de 2

            int borderWidth = 0; // Ancho del borde

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
