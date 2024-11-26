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
    public partial class BuscarPorFechas : Form
    {
        NegocioProfesor ng;
        NegocioMonografia NM;
        public BuscarPorFechas()
        {
            InitializeComponent();
            ng = new NegocioProfesor();
            NM = new NegocioMonografia();
            cargarDatos();
        }
        public void cargarDatos()
        {
            this.cmbProfesor.DataSource = ng.BuscarProfesorPorRol("Profesor");
            this.cmbProfesor.DisplayMember = "Nombres";
            this.cmbProfesor.ValueMember = "Id";
        }

        private void btnConsultarTitulos_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value.Date == null)
            {
                MessageBox.Show("Selecciona una fecha inicial");
                return;
            }

            if (dtmFechaFin.Value.Date == null)
            {
                MessageBox.Show("Selecciona una fecha final");
                return;
            }

            dataGridView1.DataSource = NM.ObtenerMonografiasConFecha(dtpFechaInicio.Value.Date, dtmFechaFin.Value.Date);

            lblTotal.Text = Convert.ToString(NM.ObtenerMonografiasConFecha(dtpFechaInicio.Value.Date, dtmFechaFin.Value.Date).Count());
            lblTotal.Visible = true;
            lblTotalTrabajo.Visible = true;
        }

        private void btnConsultaTitulos_Click(object sender, EventArgs e)
        {
            if (cmbProfesor.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un tutor valido");
                return;
            }
            dataGridView1.DataSource = NM.ObtenerMonografiasConFechayProfesor(dtpFechaInicio.Value.Date, dtmFechaFin.Value.Date,(int)cmbProfesor.SelectedValue);

            lblTotal.Text = Convert.ToString(NM.ObtenerMonografiasConFechayProfesor(dtpFechaInicio.Value.Date, dtmFechaFin.Value.Date, (int)cmbProfesor.SelectedValue).Count());
            lblTotal.Visible = true;
            lblTotalTrabajo.Visible = true;

        }
    }
}
