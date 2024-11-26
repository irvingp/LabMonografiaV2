using CapaDatos.Metodos;
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
    public partial class InsertarEstudiante : Form
    {
        CapaNegocio.NegocioEstudiante Negocio;
        Estudiantes ModEstudiante;
        public InsertarEstudiante()
        {
            InitializeComponent();
            Negocio = new CapaNegocio.NegocioEstudiante();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            this.dtgEstudiantes.DataSource = Negocio.ObtenerTodosEstudiantes();
        }
        public void Limpiar() {
            this.txtCarnet.Text = string.Empty;
            //has lo mismo para el resto de txt
            this.txtNombres.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.dateTimePicker1.Value = DateTime.Now;
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes(
                    this.txtCarnet.Text,
                    this.txtNombres.Text,
                    this.txtApellidos.Text,
                    this.txtDireccion.Text,
                    this.txtTelefono.Text,
                    this.dateTimePicker1.Value.Date
                );
            Negocio.InsertarEstudiante(estudiantes);
            ActualizarGrid();
            Limpiar();

        }

        private void InsertarEstudiante_Load(object sender, EventArgs e)
        {




        }

        private void dtgEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dtgEstudiantes.Rows[e.RowIndex];

                ModEstudiante = new Estudiantes(
                    (int)row.Cells["Id"].Value,
                    row.Cells["Carnet"].Value.ToString(),
                    row.Cells["Nombres"].Value.ToString(),
                    row.Cells["Apellidos"].Value.ToString(),
                    row.Cells["Direccion"].Value.ToString(),
                    row.Cells["Telefono"].Value.ToString(),
                    (DateTime)row.Cells["AnoNacimiento"].Value
                    );


                this.txtCarnet.Text = row.Cells["Carnet"].Value.ToString();
                this.txtNombres.Text = row.Cells["Nombres"].Value.ToString();
                this.txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                this.txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                this.txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                this.dateTimePicker1.Value = (DateTime)row.Cells["AnoNacimiento"].Value;

                var estudiante = row.DataBoundItem as Estudiantes;

                if (estudiante != null)
                {
                    // Aquí puedes realizar alguna acción con el estudiante capturado
                    MessageBox.Show($"Estudiante seleccionado: {estudiante.Nombres} {estudiante.Apellidos}");
                }
                else
                {
                    // Si el estudiante no está encontrado o no está correctamente vinculado
                    MessageBox.Show("Error al obtener el estudiante.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            ModEstudiante.Carnet = this.txtCarnet.Text;
            ModEstudiante.Nombres = this.txtNombres.Text;
            ModEstudiante.Apellidos = this.txtApellidos.Text;
            ModEstudiante.Direccion = this.txtDireccion.Text;
            ModEstudiante.Telefono = this.txtTelefono.Text;
            ModEstudiante.AnoNacimiento = this.dateTimePicker1.Value.Date;
            Negocio.ModificarEstudiante(ModEstudiante);
            ActualizarGrid();
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtCarnet.Text == null || this.txtCarnet.Text == "")
            {
                MessageBox.Show("Por favor ingresa un número de carnet valido");
            }
            else
            {
                this.dtgEstudiantes.DataSource = Negocio.BuscarPorCarent(this.txtCarnet.Text);
                Limpiar();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ModEstudiante == null)
            {
                MessageBox.Show("Por favor selecciona un estudiante");
            }else
            {

                Negocio.Eliminar(ModEstudiante.Id);
                ActualizarGrid();
                Limpiar();
            }
        }
    }
}
