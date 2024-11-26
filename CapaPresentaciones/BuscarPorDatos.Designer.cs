namespace CapaPresentaciones
{
    partial class BuscarPorDatos
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
            cmbCarnet = new ComboBox();
            btnBuscarCarnet = new Button();
            button1 = new Button();
            label2 = new Label();
            txtIdMonografia = new TextBox();
            button2 = new Button();
            cmbTutor = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 51);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Carnet Del Estudiante";
            // 
            // cmbCarnet
            // 
            cmbCarnet.FormattingEnabled = true;
            cmbCarnet.Location = new Point(42, 79);
            cmbCarnet.Name = "cmbCarnet";
            cmbCarnet.Size = new Size(182, 33);
            cmbCarnet.TabIndex = 1;
            // 
            // btnBuscarCarnet
            // 
            btnBuscarCarnet.Location = new Point(42, 132);
            btnBuscarCarnet.Name = "btnBuscarCarnet";
            btnBuscarCarnet.Size = new Size(112, 34);
            btnBuscarCarnet.TabIndex = 2;
            btnBuscarCarnet.Text = "Buscar Por Carnet";
            btnBuscarCarnet.UseVisualStyleBackColor = true;
            btnBuscarCarnet.Click += btnBuscarCarnet_Click;
            // 
            // button1
            // 
            button1.Location = new Point(42, 268);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Buscar Por Carnet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 187);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 3;
            label2.Text = "Ingresar Id Monografia";
            label2.Click += label2_Click;
            // 
            // txtIdMonografia
            // 
            txtIdMonografia.Location = new Point(43, 215);
            txtIdMonografia.Name = "txtIdMonografia";
            txtIdMonografia.Size = new Size(150, 31);
            txtIdMonografia.TabIndex = 6;
            txtIdMonografia.TextChanged += txtIdMonografia_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(41, 403);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Buscar Por Carnet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbTutor
            // 
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(41, 350);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(182, 33);
            cmbTutor.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 322);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 7;
            label3.Text = "Tutor\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(338, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(582, 383);
            dataGridView1.TabIndex = 10;
            // 
            // BuscarPorDatos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(932, 535);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(cmbTutor);
            Controls.Add(label3);
            Controls.Add(txtIdMonografia);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btnBuscarCarnet);
            Controls.Add(cmbCarnet);
            Controls.Add(label1);
            Name = "BuscarPorDatos";
            Text = "BuscarPorDatos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCarnet;
        private Button btnBuscarCarnet;
        private Button button1;
        private Label label2;
        private TextBox txtIdMonografia;
        private Button button2;
        private ComboBox cmbTutor;
        private Label label3;
        private DataGridView dataGridView1;
    }
}