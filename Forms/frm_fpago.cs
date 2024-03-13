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
        public frm_fpago(string varTipo, int varMonto)
        {
            InitializeComponent();
            this.lbl_Tipo.Text = varTipo;
            this.lbl_Monto.Text = varMonto.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
