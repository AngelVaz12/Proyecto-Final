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
    public partial class opcVenta : Form
    {
        public decimal CantidadAPagar { get; set; }

        public opcVenta()
        {
            InitializeComponent();
            Form1 ventaUsuario = Application.OpenForms.OfType<Form1>().LastOrDefault();//recuera el form1 con la informacion llenada
            string ventaPorUsuario = ventaUsuario.UsuarioAux;//obtiene el usuario del tBUsuario de Form1
            lblNom.Text = "Usuario: " + ventaPorUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUsuario formUsuario = new frmUsuario();
            formUsuario.Show();
            this.Hide(); // Oculta el formulario actual
        }

        private void efeBoton_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show($"Cantidad que se enviará a efectivo: {CantidadAPagar:C}");
            // Crear el formulario efectivo y pasar la cantidad a pagar
            efectivo formEfectivo = new efectivo
            {
                CantidadAPagar = this.CantidadAPagar // Pasa la cantidad al formulario efectivo
            };
            formEfectivo.Show();
            this.Hide();
        }

        private void tarBoton_Click_1(object sender, EventArgs e)
        {
            tarjeta formTarjeta = new tarjeta
            {
                CantidadAPagar = this.CantidadAPagar // Pasar la cantidad a pagar al formulario de tarjeta
            };
            formTarjeta.Show();
            this.Hide();
        }

        private void transBoton_Click_1(object sender, EventArgs e)
        {
            trans formTarjeta = new trans
            {
                CantidadAPagar = this.CantidadAPagar // Pasar la cantidad a pagar al formulario de tarjeta
            };
            formTarjeta.Show();
            this.Hide();
        }
    }
}
