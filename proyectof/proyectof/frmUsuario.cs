namespace proyectof
{
    public partial class frmUsuario : Form
    {
        private AdmonBD admonBD;

        public frmUsuario()
        {
            InitializeComponent();
            admonBD = new AdmonBD(); // Crear instancia de AdmonBD para iniciar la música

            ControlFunciones prodDisp = new ControlFunciones();//objeto de la clase control que llamará al metodo

            prodDisp.ordenaNombre(this);
            prodDisp.ordenaPrecio(this);
            prodDisp.ordenaImagenes(this);
            prodDisp.ordenaNUD(this);

            Form1 ventaUsuario = Application.OpenForms.OfType<Form1>().LastOrDefault();//recuera el form1 con la informacion llenada
            string ventaPorUsuario = ventaUsuario.UsuarioAux;//obtiene el usuario del tBUsuario de Form1
            lblNom.Text = "Usuario: "+ ventaPorUsuario;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Pagar_Click(object sender, EventArgs e)
        {
            ControlFunciones pagar = new ControlFunciones();
            pagar.Venta(this);
            // Obtén la cantidad calculada
            decimal cantidad = (decimal)pagar.venT;
            // Abre el formulario opcVenta y pasa la cantidad
            opcVenta formOpcVenta = new opcVenta
            {
                CantidadAPagar = cantidad // Pasa la cantidad a opcVenta
            };
            formOpcVenta.Show();
            this.Hide(); // Oculta el formulario actual
            pagar.ActualizaNUD(this);
            pagar.ReiniciaNUD(this);

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdmonBD.ActualizarFechaHora(lbHora, lbFecha);
        }
    }
}
