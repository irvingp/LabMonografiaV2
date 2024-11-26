using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentaciones
{
    public partial class InsertarProfesor : Form
    {
        CapaNegocio.NegocioProfesor Negocio;
        Profesor ModProfesor;
        public InsertarProfesor()
        {
            InitializeComponent();
            Negocio = new CapaNegocio.NegocioProfesor();
            cmbRol.Items.Add("Profesor");
            cmbRol.Items.Add("Jurado");
            ActualizarGrid();

        }

        public void ActualizarGrid()
        {
            this.dataGridView1.DataSource = Negocio.ObenerTodosProfesor();
        }
        public void Limpiar()
        {
            this.txtNombres.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.dtAnoNacimiento.Value = DateTime.Now;
            this.cmbRol.SelectedItem = null;

        }
        private void InsertarProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbRol.SelectedItem.ToString() == null || cmbRol.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Por favor selecciona un Rol para este registro ");
            }
            else
            {
                Profesor profe = new Profesor(
                       txtNombres.Text,
                       txtApellidos.Text,
                       txtDireccion.Text,
                       txtTelefono.Text,
                       dtAnoNacimiento.Value.Date,
                       cmbRol.SelectedItem.ToString()
                       );
                Negocio.InsertarProfesor(profe);
                ActualizarGrid();
                Limpiar();

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            ModProfesor.Nombres = this.txtNombres.Text;
            ModProfesor.Apellidos = this.txtApellidos.Text;
            ModProfesor.Direccion = this.txtDireccion.Text;
            ModProfesor.Telefono = this.txtTelefono.Text;
            ModProfesor.AñoDeNacimiento = this.dtAnoNacimiento.Value.Date;
            ModProfesor.Rol = this.cmbRol.SelectedText.ToString();
            Negocio.ModificarEstudiante(ModProfesor);
            ActualizarGrid();
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                ModProfesor = new Profesor(
                    (int)row.Cells["Id"].Value,
                    row.Cells["Nombres"].Value.ToString(),
                    row.Cells["Apellidos"].Value.ToString(),
                    row.Cells["Direccion"].Value.ToString(),
                    row.Cells["Telefono"].Value.ToString(),
                    (DateTime)row.Cells["AñoDeNacimiento"].Value,
                    row.Cells["Rol"].Value.ToString()

                    );


                this.txtNombres.Text = row.Cells["Nombres"].Value.ToString();
                this.txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                this.txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                this.txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                this.dtAnoNacimiento.Value = (DateTime)row.Cells["AñoDeNacimiento"].Value;
                this.cmbRol.SelectedText = row.Cells["Rol"].Value.ToString();

                var profesor = row.DataBoundItem as Profesor;

                if (profesor != null)
                {
                    // Aquí puedes realizar alguna acción con el estudiante capturado
                    MessageBox.Show($"Estudiante seleccionado: {profesor.Nombres} {profesor.Apellidos}");
                }
                else
                {
                    // Si el estudiante no está encontrado o no está correctamente vinculado
                    MessageBox.Show("Error al obtener el estudiante.");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (this.txtNombres.Text == null || this.txtNombres.Text == "")
            {
                MessageBox.Show("Por favor ingresa un nombre para buscar");
            }
            else
            {
                this.dataGridView1.DataSource = Negocio.BuscarProfesorPorNombre(this.txtNombres.Text);
                Limpiar();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ModProfesor == null)
            {
                MessageBox.Show("Por favor selecciona un profesor");
            }
            else
            {

                Negocio.Eliminar(ModProfesor.Id);
                ActualizarGrid();
                Limpiar();
            }
        }
    }
}
