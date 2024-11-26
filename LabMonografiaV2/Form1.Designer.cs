namespace LabMonografiaV2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.monografiaToolStripMenuItem,
            this.buscarPorDatosToolStripMenuItem,
            this.buscarPorFechaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1739, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("estudiantesToolStripMenuItem.Image")));
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Image = global::LabMonografiaV2.Properties.Resources.profesor;
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.profesorToolStripMenuItem.Text = "Profesor";
            this.profesorToolStripMenuItem.Click += new System.EventHandler(this.profesorToolStripMenuItem_Click);
            // 
            // monografiaToolStripMenuItem
            // 
            this.monografiaToolStripMenuItem.Image = global::LabMonografiaV2.Properties.Resources.monografia;
            this.monografiaToolStripMenuItem.Name = "monografiaToolStripMenuItem";
            this.monografiaToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.monografiaToolStripMenuItem.Text = "Monografia";
            // 
            // buscarPorDatosToolStripMenuItem
            // 
            this.buscarPorDatosToolStripMenuItem.Image = global::LabMonografiaV2.Properties.Resources.buscar;
            this.buscarPorDatosToolStripMenuItem.Name = "buscarPorDatosToolStripMenuItem";
            this.buscarPorDatosToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.buscarPorDatosToolStripMenuItem.Text = "Buscar Por Datos";
            // 
            // buscarPorFechaToolStripMenuItem
            // 
            this.buscarPorFechaToolStripMenuItem.Image = global::LabMonografiaV2.Properties.Resources.buscando;
            this.buscarPorFechaToolStripMenuItem.Name = "buscarPorFechaToolStripMenuItem";
            this.buscarPorFechaToolStripMenuItem.Size = new System.Drawing.Size(184, 29);
            this.buscarPorFechaToolStripMenuItem.Text = "Buscar Por Fecha";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::LabMonografiaV2.Properties.Resources.cerrar_sesion;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 716);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LabMonografia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monografiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

