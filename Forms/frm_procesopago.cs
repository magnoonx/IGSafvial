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
        public frm_procesopago(string varTipo, int varMonto, string varForma)
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
    }
}
