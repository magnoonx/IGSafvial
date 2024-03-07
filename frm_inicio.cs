using IGSafvial;

namespace TestConexion
{
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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


        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            // Llamada a la API
            var respuesta = await APIHelper.Login(usuario, password);

            if (respuesta.success)
            {
                // Abrir el formulario de dashboard
                var dashboard = new frm_dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(respuesta.message, "Error de Inicio");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            // Llamada a la API
            var respuesta = await APIHelper.Login(usuario, password);

            if (respuesta.success)
            {
                // Abrir el formulario de dashboard
                var dashboard = new frm_dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(respuesta.message, "Error de Inicio");
            }
        }
       
        private void btnSalirSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frm_inicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion.PerformClick();
            }
        }
    }
}
