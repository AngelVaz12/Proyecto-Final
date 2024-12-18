using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectof
{
    public partial class frmAdmin : Form
    {
        private AdmonBD admonBD;

        public frmAdmin()
        {
            InitializeComponent();
            admonBD = new AdmonBD(); // Crear instancia de AdmonBD para iniciar la música

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonModProductos_Click(object sender, EventArgs e)
        {
            frmModProd modProd = new frmModProd();
            modProd.CargarProductos();
            modProd.Show();
            this.Hide();
        }

        private void buttonConsularVentas_Click(object sender, EventArgs e)
        {
            frmConsVentas ventas = new frmConsVentas();
            ventas.CargarProductos();
            ventas.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario gráfico
            frmGrafica graphic = new frmGrafica();

            // Cargar los datos para la gráfica
            AdmonBDV obj = new AdmonBDV();
            var datosVentas = obj.consultaSinAdministrador();
            graphic.CargarGrafica(datosVentas);

            // Mostrar el nuevo formulario
            this.Hide(); // Oculta el formulario actual
            graphic.ShowDialog(); // Mostrar el gráfico como ventana modal
            this.Show(); // Vuelve a mostrar el formulario actual al cerrar la gráfica
        }

        private void buttonSalirAdmin_Click(object sender, EventArgs e)
        {
            Form1 usr = new Form1();
            usr.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdmonBD.ActualizarFechaHora(lbHora, lbFecha);
        }
    }
}
