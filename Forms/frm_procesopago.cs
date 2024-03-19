using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcorpExpress.Forms
{
    public partial class frm_procesopago : Form
    {
        
        string formaPago;
        string montoPago;
        string tipoVehiculo;

        private PrinterSettings printerSettings = new PrinterSettings();

        private PrintDocument printDocument = new PrintDocument();
        public frm_procesopago(string varTipo, string varMonto, string varForma)
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            this.lbl_Forma.Text = varForma;
            this.lbl_Monto.Text = varMonto.ToString();
            this.lbl_Tipo.Text = varTipo;
            formaPago = varForma;
            montoPago = varMonto;
            tipoVehiculo = varTipo;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string variable1 = tipoVehiculo;
            string variable2 = montoPago;
            string variable3 = formaPago;            
            Font font = new Font("Arial", 12);
            float yPos = 100;
            float xPos = 10;
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dd/MM/yyyy HH:mm:ss");


            e.Graphics.DrawString("Arcorp Express © 2024", font, Brushes.Black, xPos, yPos);
            yPos += 20;
            e.Graphics.DrawString("Tipo de Vehículo: " + variable1, font, Brushes.Black, xPos, yPos);
            yPos += 20;
            e.Graphics.DrawString("Monto: " + variable2, font, Brushes.Black, xPos, yPos);
            yPos += 20;
            e.Graphics.DrawString("Forma de Pago: " + variable3, font, Brushes.Black, xPos, yPos);
            yPos += 20;
            e.Graphics.DrawString(formattedDateTime, font, Brushes.Black, xPos, yPos);
        }
        private void frm_procesopago_Paint(object sender, PaintEventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // PrintDocument printDocument = new PrintDocument();
            printDocument.PrinterSettings.PrinterName = printDocument.PrinterSettings.PrinterName;
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Ticket", 315, 315); // Tamaño carta en 1/100 de pulgada
            printDocument.DefaultPageSettings.Margins = new Margins(20, 20, 20, 20); // Márgenes de 1 pulgada en 1/100 de pulgada
            printDocument.Print();

        }
    }
}
    
