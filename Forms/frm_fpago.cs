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
    public partial class frm_fpago : Form
    {
        private frm_procesopago frm_Procesopago;
        private frm_procpagotransfer frm_ProcesoPagoTransfer;
        private frm_exonerado frm_Exonerado;
        string vTipo;
        string vMonto;
        public frm_fpago(string varTipo, string varMonto)
        {
            InitializeComponent();
            vTipo = varTipo;
            vMonto = varMonto;
            this.lbl_Tipo.Text = vTipo.ToString();
            this.lbl_Monto.Text = vMonto;
            this.frm_Procesopago = null;
            //this.frm_Exonerado = null;
            this.frm_ProcesoPagoTransfer = null;
        }
        private void frm_fpago_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterParent;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ProcesoPago(string varTipo, string varMonto, string varForma)
        {
            if (FormularioHelper.FormularioAbierto("frm_procesopago"))
            {
                frm_Procesopago.Close();
            }
            this.frm_Procesopago = new frm_procesopago(varTipo, varMonto, varForma);
            this.frm_Procesopago.Show();
        }

        private void Exonerado(string varTipo, string varMonto, string varForma)
        {
            if (FormularioHelper.FormularioAbierto("frm_exonerado"))
            {
                frm_Exonerado.Close();
            }
            this.frm_Exonerado = new frm_exonerado(varTipo, varMonto);
            this.frm_Exonerado.Show();
        }

        private void ProcesoPagoTransfer(string varTipo, string varMonto, string varForma)
        {
            if (FormularioHelper.FormularioAbierto("frm_procpagotransfer"))
            {
                frm_ProcesoPagoTransfer.Close();
            }
            this.frm_ProcesoPagoTransfer = new frm_procpagotransfer(varTipo, varMonto, varForma);
            this.frm_ProcesoPagoTransfer.Show();
        }
        private void btn_Efectivo_Click(object sender, EventArgs e)
        {
            string varForma = "Efectivo";
            string vartipo = vTipo;
            string varMonto = vMonto;
            this.ProcesoPago(vartipo, varMonto, varForma);
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            string varForma = "Punto de Venta";
            string vartipo = vTipo;
            string varMonto = vMonto;
            this.ProcesoPago(vartipo, varMonto, varForma);
        }

        private void btn_Prepagado_Click(object sender, EventArgs e)
        {
            string varForma = "Saldo Prepagado";
            string vartipo = vTipo;
            string varMonto = vMonto;
            this.ProcesoPago(vartipo, varMonto, varForma);
        }

        private void btn_Incompleto_Click(object sender, EventArgs e)
        {
           // string varForma = "Pago Incompleto";
          //  string vartipo = vTipo;
          //  string varMonto = vMonto;
           // this.ProcesoPago(vartipo, varMonto, varForma);
           MessageBox.Show("Ésta opción no está disponible", "Opcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Incompleto.Enabled = false;
        }

        private void btn_Transferencia_Click(object sender, EventArgs e)
        {
            string varForma = "Transferencia";
            string vartipo = vTipo;
            string varMonto = vMonto;
            this.ProcesoPagoTransfer(vartipo, varMonto, varForma);
        }
        // protected override void OnPaint(PaintEventArgs e)
        // {
        //     base.OnPaint(e);
        //     System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
        //     int cornerRadius = 20; // Puedes ajustar este valor para cambiar el radio de los bordes redondeados

        //     gp.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
        //     gp.AddArc(this.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
        //      gp.AddArc(this.Width - cornerRadius * 2, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
        //     gp.AddArc(0, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);

        //      this.Region = new System.Drawing.Region(gp);
        // }

        private void frm_fpago_Paint(object sender, PaintEventArgs e)
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

        private void btn_Exonerado_Click(object sender, EventArgs e)
        {
            string varForma = "Exonerado";
            string vartipo = vTipo;
            string varMonto = vMonto;
            this.Exonerado(vartipo, varMonto, varForma);
        }
    }



}
