namespace CapaPresentaciones
{
    partial class InsertarProfesor
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
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtAnoNacimiento = new DateTimePicker();
            label6 = new Label();
            cmbRol = new ComboBox();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 78);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(211, 75);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(219, 31);
            txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(211, 140);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(219, 31);
            txtApellidos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 143);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(211, 193);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(219, 31);
            txtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 196);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 4;
            label3.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(211, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(219, 31);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 255);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 327);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 8;
            label5.Text = "Año Nacimiento";
            // 
            // dtAnoNacimiento
            // 
            dtAnoNacimiento.Location = new Point(211, 321);
            dtAnoNacimiento.Name = "dtAnoNacimiento";
            dtAnoNacimiento.Size = new Size(300, 31);
            dtAnoNacimiento.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 388);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 10;
            label6.Text = "Asignar Rol";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(211, 380);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(219, 33);
            cmbRol.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(568, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(814, 378);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1051, 473);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(882, 473);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(739, 473);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(578, 473);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // InsertarProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1430, 586);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(cmbRol);
            Controls.Add(label6);
            Controls.Add(dtAnoNacimiento);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombres);
            Controls.Add(label1);
            Name = "InsertarProfesor";
            Text = "InsertarProfesor";
            Load += InsertarProfesor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private Label label5;
        private DateTimePicker dtAnoNacimiento;
        private Label label6;
        private ComboBox cmbRol;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnInsert;
    }
}