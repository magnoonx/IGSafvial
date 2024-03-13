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
        string vTipo;
        int vMonto;
        public frm_fpago(string varTipo, int varMonto)
        {
            InitializeComponent();
            vTipo = varTipo;
            vMonto = varMonto;
            this.lbl_Tipo.Text = vTipo;
            this.lbl_Monto.Text = vMonto.ToString();
            this.frm_Procesopago = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ProcesoPago(string varTipo, int varMonto, string varForma)
        {
            if (FormularioHelper.FormularioAbierto("frm_procesopago"))
            {
                frm_Procesopago.Close();
            }
            this.frm_Procesopago = new frm_procesopago(varTipo, varMonto, varForma);
            this.frm_Procesopago.Show();
        }

        private void btn_Efectivo_Click(object sender, EventArgs e)
        {
            string varForma = "Efectivo";
            string vartipo = vTipo;
            int varMonto = vMonto;
            this.ProcesoPago(vartipo, varMonto, varForma);
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            string varForma = "Punto de Venta";
            string vartipo = vTipo;
            int varMonto = vMonto;
            this.ProcesoPago(vartipo, varMonto, varForma);
        }

        private void btn_Prepagado_Click(object sender, EventArgs e)
        {
            string varForma = "Saldo Prepagado";
            string vartipo = vTipo;
            int varMonto = vMonto;
            this.ProcesoPago(vartipo, varMonto, varForma);
        }

        private void btn_Incompleto_Click(object sender, EventArgs e)
        {
            string varForma = "Pago Incompleto";
            string vartipo = vTipo;
            int varMonto = vMonto;
            this.ProcesoPago(vartipo, varMonto, varForma);
        }

        private void btn_Transferencia_Click(object sender, EventArgs e)
        {
            string varForma = "Transferencia";
            string vartipo = vTipo;
            int varMonto = vMonto;
            this.ProcesoPago(vartipo, varMonto, varForma);
        }
    }

}
