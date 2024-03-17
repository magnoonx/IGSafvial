using ArcorpExpress.Forms;
using ArcorpExpress.Models;
using Newtonsoft.Json;
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
using TestConexion;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;


namespace ArcorpExpress
{
    public partial class frm_dashboard : Form
    {
        string tokenactual;
        string JSesperado;
       // string nombreactual;
        private frm_fpago frm_Fpago;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point();

        public frm_dashboard(string tokenActual, string nombre, string apellido, string perfil, int idusuario)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "Config/config.txt";
            string filePath = Path.Combine(currentDirectory, fileName);
            int lineaSede = 3;
            int lineaCanal = 4;

            tokenactual = tokenActual;           
            InitializeComponent();            
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;            
            this.frm_Fpago = null;
            this.txtUsuario.Text = "Usuario: " + nombre + " " + apellido;
            this.txtSede.Text = File.ReadLines(filePath).Skip(lineaSede - 1).FirstOrDefault();
            this.txtCanal.Text = File.ReadLines(filePath).Skip(lineaCanal - 1).FirstOrDefault();
        }

        private async void frm_dashboard_Load(object sender, EventArgs e)
        {
            string Token = tokenactual;
            var respuesta = await APIHelper.Dash(Token);
            if (respuesta != null)
            {
                JSesperado = respuesta.ToString();
            }
            else
            {
                MessageBox.Show("No hay conexión con la API, por favor revise el archivo de configuración e intente nuevamente", "Se cerrará la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje Prueba");
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
            string Nombre = "2 Ejes"; 
            this.OpenfPago(Nombre);  
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {            
            string Nombre = "4 Ejes";  
            this.OpenfPago(Nombre);    
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_VentaExpress_Click(object sender, EventArgs e)
        {
            string Nombre = "Prepagada";
           
            this.OpenfPago(Nombre);    
        }

        private async void OpenfPago(string Nombre)
        {
            List<tfActual> tarifas = JsonConvert.DeserializeObject<List<tfActual>>(JSesperado);            
            tfActual TarifaBuscada = tarifas.Find(r => r.nombre == Nombre);           
            try
           {
               if (tarifas != null) 
               {
                    if (FormularioHelper.FormularioAbierto("frm_fpago"))
                   {
                       frm_Fpago.Close();
                   }

                    // Abre formulario de forma de pago y pasa las variables obtenidas de API
                    
                    if (Nombre == "Prepagada")
                    {
                       string NombreVenta = "Venta Express";
                       this.frm_Fpago = new frm_fpago(NombreVenta, TarifaBuscada.tarifa);
                       this.frm_Fpago.Show();
                    }
                    else
                    {
                        this.frm_Fpago = new frm_fpago(Nombre, TarifaBuscada.tarifa);
                        this.frm_Fpago.Show();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La tarifa no es válida", "Error de Tarifa");
            }
        }

        private void btn_Liviano_Click(object sender, EventArgs e)
        {
           
            string Nombre = "Liviano";  
            this.OpenfPago(Nombre);        
        }

        private void btn_Microbus_Click(object sender, EventArgs e)
        {
           
            string Nombre = "Microbus"; 
            this.OpenfPago(Nombre);  

        }

        private void btn_Autobus_Click(object sender, EventArgs e)
        {
            
            string Nombre = "Autobus";
            this.OpenfPago(Nombre);    

        }

        private void btn_350_Click(object sender, EventArgs e)
        {
            
            string Nombre = "Carga Liviana"; 
            this.OpenfPago(Nombre);     

        }

        private void btn_3ejes_Click(object sender, EventArgs e)
        {
            
            string Nombre = "3 Ejes"; 
            this.OpenfPago(Nombre);               

        }

        private void btn_5ejes_Click(object sender, EventArgs e)
        {
            
            string Nombre = "5 Ejes";
            this.OpenfPago(Nombre); 
        }

        private void btn_6ejes_Click(object sender, EventArgs e)
        {
            
            string Nombre = "6 Ejes o Mas"; 
            this.OpenfPago(Nombre); 
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


       


    }

}

