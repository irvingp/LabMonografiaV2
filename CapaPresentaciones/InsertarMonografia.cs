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
    public partial class InsertarMonografia : Form
    {
        NegocioProfesor NegocioProfesor;
        NegocioEstudiante NegocioEstudiante;
        NegocioMonografia NegocioMonografia;
        public InsertarMonografia()
        {
            InitializeComponent();
            NegocioEstudiante = new NegocioEstudiante();
            NegocioProfesor = new NegocioProfesor();
            NegocioMonografia = new NegocioMonografia();
            Load();
        }

        public void Load()
        {
            this.cmbTutor.DataSource = NegocioProfesor.BuscarProfesorPorRol("Profesor");
            this.cmbTutor.DisplayMember = "Nombres";
            this.cmbTutor.ValueMember = "Id";

            this.cbEstudiantes.DataSource = NegocioEstudiante.ObtenerTodosEstudiantes();
            this.cbEstudiantes.DisplayMember = "Nombres";
            this.cbEstudiantes.ValueMember = "Id";

            this.cbJurado.DataSource = NegocioProfesor.BuscarProfesorPorRol("Jurado");
            this.cbJurado.DisplayMember = "Nombres";
            this.cbJurado.ValueMember = "Id";

        }
        private void LimpiarCampos()
        {

            this.txtTitulo.Clear();
            this.txtTiempoAcordado.Clear();
            this.cmbTutor.SelectedIndex = -1;
            this.txtNotaDefensa.Clear();
            this.txTiempoDefensa.Clear();
            this.txtTiempoPreguntasYRespuestas.Clear();
            this.dtpFechaDefensa.Value = DateTime.Now;
            this.cbEstudiantes.ClearSelected();
            this.cbJurado.ClearSelected();


            for (int i = 0; i < cbJurado.Items.Count; i++)
            {
                cbJurado.SetItemChecked(i, false);
            }
            for (int i = 0; i < cbEstudiantes.Items.Count; i++)
            {
                cbEstudiantes.SetItemChecked(i, false);
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (cmbTutor.SelectedValue == null || cbJurado.CheckedItems.Count != 2 || cbEstudiantes.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un tutor, dos jurados y al menos un estudiante para la monografía.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que no se hayan seleccionado más de tres estudiantes
            if (cbEstudiantes.CheckedItems.Count > 3)
            {
                MessageBox.Show("Solo puedes seleccionar hasta tres estudiantes para la monografía.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Profesor tutor = NegocioProfesor.BuscarProfesorPorId((int)cmbTutor.SelectedValue);
            List<Profesor> Jurado = cbJurado.CheckedItems.Cast<Profesor>().ToList();
            List<Estudiantes> Estudiantes = cbEstudiantes.CheckedItems.Cast<Estudiantes>().ToList();

            List<Profesor> profesors = new List<Profesor>();    

            profesors.Add(tutor);
          


            Monografia nuevaMonografia = new Monografia(
                this.txtTitulo.Text,
                this.dtpFechaDefensa.Value.Date,
                Convert.ToDouble(txtNotaDefensa.Text),
                Convert.ToDouble(txtTiempoAcordado.Text),
                Convert.ToDouble(txTiempoDefensa.Text),
                Convert.ToDouble(txtTiempoPreguntasYRespuestas.Text),
                DateTime.Now.Date
                );
            
            if(NegocioMonografia.InsertarMonografia(nuevaMonografia, Estudiantes, Jurado,profesors) != 0 )

            {

                MessageBox.Show("Monografía agregada con éxito", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }
    }
}
