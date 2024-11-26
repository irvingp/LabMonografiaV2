namespace CapaPresentaciones
{
    partial class BuscarPorFechas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dtpFechaInicio = new DateTimePicker();
            btnConsultarTitulos = new Button();
            cmbProfesor = new ComboBox();
            btnConsultaTitulos = new Button();
            dtmFechaFin = new DateTimePicker();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            lblTotalTrabajo = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 29);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 189);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Profesor";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(65, 57);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(300, 31);
            dtpFechaInicio.TabIndex = 2;
            // 
            // btnConsultarTitulos
            // 
            btnConsultarTitulos.Location = new Point(65, 94);
            btnConsultarTitulos.Name = "btnConsultarTitulos";
            btnConsultarTitulos.Size = new Size(263, 44);
            btnConsultarTitulos.TabIndex = 3;
            btnConsultarTitulos.Text = "Total Trabajos";
            btnConsultarTitulos.UseVisualStyleBackColor = true;
            btnConsultarTitulos.Click += btnConsultarTitulos_Click;
            // 
            // cmbProfesor
            // 
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Location = new Point(65, 217);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(182, 33);
            cmbProfesor.TabIndex = 4;
            // 
            // btnConsultaTitulos
            // 
            btnConsultaTitulos.Location = new Point(65, 366);
            btnConsultaTitulos.Name = "btnConsultaTitulos";
            btnConsultaTitulos.Size = new Size(263, 44);
            btnConsultaTitulos.TabIndex = 7;
            btnConsultaTitulos.Text = "Total trabajos (tutor)";
            btnConsultaTitulos.UseVisualStyleBackColor = true;
            btnConsultaTitulos.Click += btnConsultaTitulos_Click;
            // 
            // dtmFechaFin
            // 
            dtmFechaFin.Location = new Point(65, 329);
            dtmFechaFin.Name = "dtmFechaFin";
            dtmFechaFin.Size = new Size(300, 31);
            dtmFechaFin.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 301);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 5;
            label3.Text = "Fecha Fin ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(805, 338);
            dataGridView1.TabIndex = 8;
            // 
            // lblTotalTrabajo
            // 
            lblTotalTrabajo.AutoSize = true;
            lblTotalTrabajo.Location = new Point(1051, 417);
            lblTotalTrabajo.Name = "lblTotalTrabajo";
            lblTotalTrabajo.Size = new Size(120, 25);
            lblTotalTrabajo.TabIndex = 9;
            lblTotalTrabajo.Text = "Total Trabajo: ";
            lblTotalTrabajo.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1168, 417);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(120, 25);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total Trabajo: ";
            lblTotal.Visible = false;
            // 
            // BuscarPorFechas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 461);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalTrabajo);
            Controls.Add(dataGridView1);
            Controls.Add(btnConsultaTitulos);
            Controls.Add(dtmFechaFin);
            Controls.Add(label3);
            Controls.Add(cmbProfesor);
            Controls.Add(btnConsultarTitulos);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BuscarPorFechas";
            Text = "BuscarPorFechas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpFechaInicio;
        private Button btnConsultarTitulos;
        private ComboBox cmbProfesor;
        private Button btnConsultaTitulos;
        private DateTimePicker dtmFechaFin;
        private Label label3;
        private DataGridView dataGridView1;
        private Label lblTotalTrabajo;
        private Label lblTotal;
    }
}