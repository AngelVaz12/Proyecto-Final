using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace proyectof
{
    public partial class frmConsVentas : Form
    {

        public frmConsVentas()
        {
            InitializeComponent();

        }

        public void CargarProductos()
        {
            // Para mostrar los productos
            AdmonBDV obj = new AdmonBDV();
            var data = obj.consultaSinAdministrador();
            data = obj.consultaSinAdministrador();
            obj.ActualizarVentasAdministrador();

            /* Muestra la información en el DataGridView */
            this.dataGridView1.DataSource = null; // Limpia el DataGridView
            this.dataGridView1.DataSource = data;

            obj.Disconnect();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            this.Close();
            admin.Show();
        }

        private void ActualizarVentasAdministrador()
        {
            AdmonBDV obj = new AdmonBDV();
            int ventasAdmin = obj.ObtenerVentasAdministrador();
            textBox1.Text = ventasAdmin.ToString();//Muestra las venntas en el Text box
            obj.Disconnect();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)//boton que actualiza el datagrid y el textbox de administrador
        {
            ActualizarVentasAdministrador();
            CargarProductos();
        }

        private void frmConsVentas_Load(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            AdmonBD.ActualizarFechaHora(lbHora, lbFecha);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdmonBD.ActualizarFechaHora(lbHora, lbFecha);
        }
    }
}