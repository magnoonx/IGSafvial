using ArcorpExpress.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;


namespace ArcorpExpress
{
    public partial class frm_dashboard : Form
    {
        private frm_fpago frm_Fpago;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point();

        public frm_dashboard()
        {
            InitializeComponent();
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.frm_Fpago = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se cerrara la sesión y aplicacion ¿Desea Continuar?", "ARCORP EXPRESS", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            //cambiar el boton
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.guna2TextBox6.Text = DateTime.Now.ToShortDateString();
            this.guna2TextBox7.Text = DateTime.Now.ToLongTimeString();
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            this.guna2TextBox6.Text = DateTime.Now.ToShortDateString();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {
            this.guna2TextBox7.Text = DateTime.Now.ToLongTimeString();
        }

        private void guna2Panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void guna2Panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void guna2Panel2_MouseUp_1(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            int opcion = 5;
            this.Suiche(opcion); 
            
           
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            int opcion = 7;
            this.Suiche(opcion); 
            
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_VentaExpress_Click(object sender, EventArgs e)
        {
            int opcion = 0;
            this.Suiche(opcion);
            
            

        }

        private void OpenfPago(string varTipo, int varMonto)
        {
            // Abre formulario de forma de pago y pasa las variables obtenidas de API
            this.frm_Fpago = new frm_fpago(varTipo, varMonto);
            this.frm_Fpago.Show();
        }

        private void btn_Liviano_Click(object sender, EventArgs e)
        {
            int opcion = 1;
            this.Suiche(opcion);           
        }

        private void btn_Microbus_Click(object sender, EventArgs e)
        {
            int opcion = 2;
            this.Suiche(opcion);         
          
        }

        private void btn_Autobus_Click(object sender, EventArgs e)
        {
            int opcion = 3;
            this.Suiche(opcion);            
           
        }

        private void btn_350_Click(object sender, EventArgs e)
        {
            int opcion = 4;
            this.Suiche(opcion);             
           
        }

        private void btn_3ejes_Click(object sender, EventArgs e)
        {
            int opcion = 6;
            this.Suiche(opcion);             
            
        }

        private void btn_5ejes_Click(object sender, EventArgs e)
        {
            int opcion = 8;
            this.Suiche(opcion);             
            
        }

        private void btn_6ejes_Click(object sender, EventArgs e)
        {
            int opcion = 9;
            this.Suiche(opcion);   
            
        }
      private void Suiche(int opcion)
        {
            string varTipo;
            int varMonto;

            switch (opcion)
            {
                case 0:
                     varTipo = "Venta Express";  // Reemplazar con el valor real otorgado por API
                     varMonto = 3;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 1:
                     varTipo = "Vehículo Liviano";  // Reemplazar con el valor real otorgado por API
                     varMonto = 5;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 2:
                     varTipo = "Microbus";  // Reemplazar con el valor real otorgado por API
                     varMonto = 10; // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 3:
                     varTipo = "Autobus";  // Reemplazar con el valor real otorgado por API
                     varMonto = 15;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 4:
                     varTipo = "Camion 350";  // Reemplazar con el valor real otorgado por API
                     varMonto = 20;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 5:
                     varTipo = "Camion 750";  // Reemplazar con el valor real otorgado por API
                     varMonto = 25;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 6:
                     varTipo = "Camion 3 Ejes";  // Reemplazar con el valor real otorgado por API
                     varMonto = 30;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 7:
                     varTipo = "Camion 4 ejes";  // Reemplazar con el valor real otorgado por API
                     varMonto = 35;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 8:
                     varTipo = "Camion 5 Ejes";  // Reemplazar con el valor real otorgado por API
                     varMonto = 40;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                case 9:
                     varTipo = "Camion 6 Ejes";  // Reemplazar con el valor real otorgado por API
                     varMonto = 45;  // Quitar y ubicar en la respuesta obtenida de la API
                    this.OpenfPago(varTipo, varMonto); // quitar y ubicar en la llamada a la API (CallAPI)
                    break;
                default: break;

            }
        }

       // private async void CallAPI(string Tipo, string Tarifa)
       // {
       //     var respuesta = await APIHelper.Tarifa(Tipo, Tarifa);
       //     this.OpenfPago(varTipo, varMonto);
       // }


}

}

