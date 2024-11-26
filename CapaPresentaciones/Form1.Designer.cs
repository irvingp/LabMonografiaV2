namespace CapaPresentaciones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            insertarEstudianteToolStripMenuItem = new ToolStripMenuItem();
            ingresarProfesorToolStripMenuItem = new ToolStripMenuItem();
            ingresarMonografiaToolStripMenuItem = new ToolStripMenuItem();
            buscarPorDatosToolStripMenuItem = new ToolStripMenuItem();
            buscarPorFechaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { insertarEstudianteToolStripMenuItem, ingresarProfesorToolStripMenuItem, ingresarMonografiaToolStripMenuItem, buscarPorDatosToolStripMenuItem, buscarPorFechaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1288, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // insertarEstudianteToolStripMenuItem
            // 
            insertarEstudianteToolStripMenuItem.Image = Properties.Resources.graduado;
            insertarEstudianteToolStripMenuItem.Name = "insertarEstudianteToolStripMenuItem";
            insertarEstudianteToolStripMenuItem.Size = new Size(198, 29);
            insertarEstudianteToolStripMenuItem.Text = "Insertar Estudiante";
            insertarEstudianteToolStripMenuItem.Click += insertarEstudianteToolStripMenuItem_Click;
            // 
            // ingresarProfesorToolStripMenuItem
            // 
            ingresarProfesorToolStripMenuItem.Image = Properties.Resources.profesor;
            ingresarProfesorToolStripMenuItem.Name = "ingresarProfesorToolStripMenuItem";
            ingresarProfesorToolStripMenuItem.Size = new Size(188, 29);
            ingresarProfesorToolStripMenuItem.Text = "Ingresar Profesor";
            ingresarProfesorToolStripMenuItem.Click += ingresarProfesorToolStripMenuItem_Click;
            // 
            // ingresarMonografiaToolStripMenuItem
            // 
            ingresarMonografiaToolStripMenuItem.Image = Properties.Resources.monografia;
            ingresarMonografiaToolStripMenuItem.Name = "ingresarMonografiaToolStripMenuItem";
            ingresarMonografiaToolStripMenuItem.Size = new Size(214, 29);
            ingresarMonografiaToolStripMenuItem.Text = "Ingresar Monografia";
            ingresarMonografiaToolStripMenuItem.Click += ingresarMonografiaToolStripMenuItem_Click;
            // 
            // buscarPorDatosToolStripMenuItem
            // 
            buscarPorDatosToolStripMenuItem.BackColor = SystemColors.ControlLightLight;
            buscarPorDatosToolStripMenuItem.Image = Properties.Resources.buscar;
            buscarPorDatosToolStripMenuItem.Name = "buscarPorDatosToolStripMenuItem";
            buscarPorDatosToolStripMenuItem.Size = new Size(186, 29);
            buscarPorDatosToolStripMenuItem.Text = "Buscar Por Datos";
            buscarPorDatosToolStripMenuItem.Click += buscarPorDatosToolStripMenuItem_Click;
            // 
            // buscarPorFechaToolStripMenuItem
            // 
            buscarPorFechaToolStripMenuItem.Image = Properties.Resources.buscando;
            buscarPorFechaToolStripMenuItem.Name = "buscarPorFechaToolStripMenuItem";
            buscarPorFechaToolStripMenuItem.Size = new Size(189, 29);
            buscarPorFechaToolStripMenuItem.Text = "Buscar Por Fecha ";
            buscarPorFechaToolStripMenuItem.Click += buscarPorFechaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 419);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem insertarEstudianteToolStripMenuItem;
        private ToolStripMenuItem ingresarProfesorToolStripMenuItem;
        private ToolStripMenuItem ingresarMonografiaToolStripMenuItem;
        private ToolStripMenuItem buscarPorDatosToolStripMenuItem;
        private ToolStripMenuItem buscarPorFechaToolStripMenuItem;
    }
}
