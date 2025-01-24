namespace WinFormsCliente
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
            dgViews = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            LU = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            btnListar = new Button();
            btnBuscarAlumno = new Button();
            btnAgregarAlumno = new Button();
            btnEditarAlumno = new Button();
            btnBorrarAlumno = new Button();
            lbNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbNombre = new TextBox();
            tbLU = new TextBox();
            tbNota = new TextBox();
            tbID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgViews).BeginInit();
            SuspendLayout();
            // 
            // dgViews
            // 
            dgViews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViews.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, LU, Nota });
            dgViews.Location = new Point(12, 108);
            dgViews.Name = "dgViews";
            dgViews.Size = new Size(444, 245);
            dgViews.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // LU
            // 
            LU.HeaderText = "LU";
            LU.Name = "LU";
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(482, 108);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(114, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscarAlumno
            // 
            btnBuscarAlumno.Location = new Point(482, 148);
            btnBuscarAlumno.Name = "btnBuscarAlumno";
            btnBuscarAlumno.Size = new Size(114, 23);
            btnBuscarAlumno.TabIndex = 2;
            btnBuscarAlumno.Text = "Buscar Alumno";
            btnBuscarAlumno.UseVisualStyleBackColor = true;
            btnBuscarAlumno.Click += btnBuscarAlumno_Click;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(482, 189);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(114, 23);
            btnAgregarAlumno.TabIndex = 3;
            btnAgregarAlumno.Text = "Agregar Alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // btnEditarAlumno
            // 
            btnEditarAlumno.Location = new Point(482, 229);
            btnEditarAlumno.Name = "btnEditarAlumno";
            btnEditarAlumno.Size = new Size(114, 23);
            btnEditarAlumno.TabIndex = 4;
            btnEditarAlumno.Text = "Editar Alumno";
            btnEditarAlumno.UseVisualStyleBackColor = true;
            btnEditarAlumno.Click += btnEditarAlumno_Click;
            // 
            // btnBorrarAlumno
            // 
            btnBorrarAlumno.Location = new Point(482, 287);
            btnBorrarAlumno.Name = "btnBorrarAlumno";
            btnBorrarAlumno.Size = new Size(114, 23);
            btnBorrarAlumno.TabIndex = 5;
            btnBorrarAlumno.Text = "Borrar Alumno";
            btnBorrarAlumno.UseVisualStyleBackColor = true;
            btnBorrarAlumno.Click += btnBorrarAlumno_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(17, 16);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 6;
            lbNombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 51);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 7;
            label2.Text = "LU:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 16);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Nota:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 55);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 9;
            label4.Text = "ID:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(77, 13);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 10;
            // 
            // tbLU
            // 
            tbLU.Location = new Point(47, 48);
            tbLU.Name = "tbLU";
            tbLU.Size = new Size(130, 23);
            tbLU.TabIndex = 11;
            // 
            // tbNota
            // 
            tbNota.Location = new Point(281, 13);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(100, 23);
            tbNota.TabIndex = 12;
            // 
            // tbID
            // 
            tbID.Location = new Point(281, 53);
            tbID.Name = "tbID";
            tbID.Size = new Size(100, 23);
            tbID.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbID);
            Controls.Add(tbNota);
            Controls.Add(tbLU);
            Controls.Add(tbNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbNombre);
            Controls.Add(btnBorrarAlumno);
            Controls.Add(btnEditarAlumno);
            Controls.Add(btnAgregarAlumno);
            Controls.Add(btnBuscarAlumno);
            Controls.Add(btnListar);
            Controls.Add(dgViews);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgViews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgViews;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn LU;
        private DataGridViewTextBoxColumn Nota;
        private Button btnListar;
        private Button btnBuscarAlumno;
        private Button btnAgregarAlumno;
        private Button btnEditarAlumno;
        private Button btnBorrarAlumno;
        private Label lbNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbNombre;
        private TextBox tbLU;
        private TextBox tbNota;
        private TextBox tbID;
    }
}
