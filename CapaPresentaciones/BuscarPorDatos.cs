using CapaDatos.Modelo;
using CapaNegocio;
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
    public partial class BuscarPorDatos : Form
    {
        NegocioMonografia Nm;
        NegocioEstudiante NegocioEstudiante;
        NegocioProfesor NegocioProfesor;
        public BuscarPorDatos()
        {
            InitializeComponent();
            Nm = new NegocioMonografia();
            NegocioEstudiante = new NegocioEstudiante();
            NegocioProfesor = new NegocioProfesor();

            CargarDatos();
        }

        public void CargarDatos()
        {
            cmbCarnet.DataSource = NegocioEstudiante.ObtenerTodosEstudiantes();
            this.cmbCarnet.DisplayMember = "Nombres";
            this.cmbCarnet.ValueMember = "Carnet";

            cmbTutor.DataSource = NegocioProfesor.BuscarProfesorPorRol("Profesor");
            cmbTutor.DisplayMember = "Nombres";
            cmbTutor.ValueMember = "Id";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCarnet_Click(object sender, EventArgs e)
        {
            var carnetEstudiante = ((Estudiantes)cmbCarnet.SelectedItem).Carnet;

            List<CapaDatos.DTOs.MonografiaEstudianteDTO> datos = Nm.BuscarPorCarne(carnetEstudiante);


            if (datos == null)
            {
                MessageBox.Show("No se encontró una monografía asociada a este estudiante.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dataGridView1.DataSource = datos;



        }

        private void txtIdMonografia_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdMonografia.Text == null || txtIdMonografia.Text == "")
            {
                MessageBox.Show("Por favor ingresar un id de Monografia correco");
            }
            else
            {
                dataGridView1.DataSource = Nm.BuscarPorIdMonografia(Convert.ToInt32(txtIdMonografia.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cmbTutor.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un tutor");

            }
            else
            {

                dataGridView1.DataSource = Nm.BuscarporIdTutor(Convert.ToInt32(cmbTutor.SelectedValue));
            }
        }
    }
}
