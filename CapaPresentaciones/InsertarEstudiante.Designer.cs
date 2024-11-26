namespace CapaPresentaciones
{
    partial class InsertarEstudiante
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
            Carnet = new Label();
            txtCarnet = new TextBox();
            txtNombres = new TextBox();
            label1 = new Label();
            txtApellidos = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dtgEstudiantes = new DataGridView();
            btnInsert = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // Carnet
            // 
            Carnet.AutoSize = true;
            Carnet.Location = new Point(47, 59);
            Carnet.Name = "Carnet";
            Carnet.Size = new Size(63, 25);
            Carnet.TabIndex = 0;
            Carnet.Text = "Carnet";
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(212, 56);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(232, 31);
            txtCarnet.TabIndex = 1;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(212, 125);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(232, 31);
            txtNombres.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 128);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombres";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(212, 187);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(232, 31);
            txtApellidos.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 190);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 4;
            label2.Text = "Apellidos";
            label2.Click += label2_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(212, 245);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(232, 31);
            txtDireccion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 248);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 6;
            label3.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(212, 297);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(232, 31);
            txtTelefono.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 300);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 8;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 349);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 10;
            label5.Text = "Año de Nacimiento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 350);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 31);
            dateTimePicker1.TabIndex = 11;
            // 
            // dtgEstudiantes
            // 
            dtgEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstudiantes.Location = new Point(499, 50);
            dtgEstudiantes.Name = "dtgEstudiantes";
            dtgEstudiantes.RowHeadersWidth = 62;
            dtgEstudiantes.RowTemplate.Height = 33;
            dtgEstudiantes.Size = new Size(792, 343);
            dtgEstudiantes.TabIndex = 12;
            dtgEstudiantes.CellClick += dtgEstudiantes_CellClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(499, 448);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(660, 448);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(803, 448);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(972, 448);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // InsertarEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1367, 650);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsert);
            Controls.Add(dtgEstudiantes);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombres);
            Controls.Add(label1);
            Controls.Add(txtCarnet);
            Controls.Add(Carnet);
            Name = "InsertarEstudiante";
            Text = "InsertarEstudiante";
            Load += InsertarEstudiante_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Carnet;
        private TextBox txtCarnet;
        private TextBox txtNombres;
        private Label label1;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DataGridView dtgEstudiantes;
        private Button btnInsert;
        private Button btnModificar;
        private Button btnBuscar;
        private Button btnEliminar;
    }
}