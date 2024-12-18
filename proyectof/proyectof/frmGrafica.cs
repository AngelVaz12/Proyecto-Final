using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace proyectof
{
    public partial class frmGrafica : Form
    {
        public frmGrafica()
        {
            InitializeComponent();
        }
        public void CargarGrafica(List<Sales> ventas)
        {
            // Limpiar series anteriores
            this.chart1.Series.Clear();

            // Crear una nueva serie para el gráfico de pastel
            Series series = new Series("Ventas")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true // Muestra las etiquetas en el gráfico
            };

            // Agregar datos a la serie
            foreach (var venta in ventas)
            {
                if (venta.Nombre != "Administrador") // Excluir al Administrador
                {
                    series.Points.AddXY(venta.Nombre, venta.Ventas);
                }
            }

            // Agregar la serie al gráfico
            this.chart1.Series.Add(series);

            // Configurar el diseño del gráfico
            chart1.Titles.Clear();
            chart1.Titles.Add("Ventas por Usuario");
            chart1.Legends[0].Enabled = true; // Habilitar la leyenda
        }



        private void frmGrafica_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            this.Close();
            //admin.Show();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                // Crear una instancia de la clase AdmonBDV para conectar a la base de datos
                AdmonBDV admonBDV = new AdmonBDV();

                // Obtener la lista de ventas desde la base de datos
                List<Sales> updatedVentas = admonBDV.consultaSinAdministrador();

                // Actualizar la gráfica con los datos obtenidos
                CargarGrafica(updatedVentas);

                // Desconectar la base de datos después de usarla
                admonBDV.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la gráfica: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdmonBD.ActualizarFechaHora(lbHora, lbFecha);
        }
    }
}
