using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ArcorpExpress
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_Load_1(object sender, EventArgs e)
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
	}
}
