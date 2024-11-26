namespace CapaPresentaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void insertarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarEstudiante frmInsertarEstudiante = new InsertarEstudiante();
            frmInsertarEstudiante.Show();
        }

        private void ingresarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarProfesor frm = new InsertarProfesor();
            frm.Show();
        }

        private void ingresarMonografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarMonografia frm = new InsertarMonografia();
            frm.Show();
        }

        private void buscarPorDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPorDatos frm = new BuscarPorDatos();
            frm.Show();

        }

        private void buscarPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {BuscarPorFechas frm = new BuscarPorFechas();   
            frm.Show();

        }
    }
}
