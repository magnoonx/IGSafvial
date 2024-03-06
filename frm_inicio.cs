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
    }
}
