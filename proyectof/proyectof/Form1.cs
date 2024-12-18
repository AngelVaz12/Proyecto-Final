using MySql.Data.MySqlClient;

namespace proyectof
{
    public partial class Form1 : Form
    {
        public string UsuarioAux { get; set; }
        MySqlConnection conectarBD = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");
        private AdmonBD admonBD;

        public Form1()
        {
            InitializeComponent();
            admonBD = new AdmonBD(); // Crear instancia de AdmonBD para iniciar la música
        }

        private void buttonIngresa_Click(object sender, EventArgs e)
        {
            string usuario = tBUsuario.Text;
            string password = tBPassword.Text;
            UsuarioAux = tBUsuario.Text;
            try
            {
                ControlFunciones ctrl = new ControlFunciones();
                string respuesta = ctrl.ctrlLogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (tBUsuario.Text == "administrador")
                    {
                        frmAdmin frmAdm = new frmAdmin();
                        frmAdm.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmUsuario frmU = new frmUsuario();
                        frmU.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
