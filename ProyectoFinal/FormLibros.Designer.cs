namespace ProyectoFinal
{
    partial class FormLibros
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
            this.btnAltaLibro = new System.Windows.Forms.Button();
            this.btnBajaLibro = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtCantEjemplares = new System.Windows.Forms.TextBox();
            this.txtAnioPublicacion = new System.Windows.Forms.TextBox();
            this.grpDatosLibros = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            this.grpDatosLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaLibro
            // 
            this.btnAltaLibro.Location = new System.Drawing.Point(496, 262);
            this.btnAltaLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltaLibro.Name = "btnAltaLibro";
            this.btnAltaLibro.Size = new System.Drawing.Size(138, 102);
            this.btnAltaLibro.TabIndex = 0;
            this.btnAltaLibro.Text = "Dar de Alta";
            this.btnAltaLibro.UseVisualStyleBackColor = true;
            this.btnAltaLibro.Click += new System.EventHandler(this.btnAltaLibro_Click_1);
            // 
            // btnBajaLibro
            // 
            this.btnBajaLibro.Location = new System.Drawing.Point(713, 262);
            this.btnBajaLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBajaLibro.Name = "btnBajaLibro";
            this.btnBajaLibro.Size = new System.Drawing.Size(120, 102);
            this.btnBajaLibro.TabIndex = 1;
            this.btnBajaLibro.Text = "Dar de Baja";
            this.btnBajaLibro.UseVisualStyleBackColor = true;
            this.btnBajaLibro.Click += new System.EventHandler(this.btnBajaLibro_Click_1);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(178, 38);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(167, 20);
            this.txtISBN.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(178, 80);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(167, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(178, 122);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(167, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // txtCantEjemplares
            // 
            this.txtCantEjemplares.Location = new System.Drawing.Point(178, 190);
            this.txtCantEjemplares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantEjemplares.Name = "txtCantEjemplares";
            this.txtCantEjemplares.Size = new System.Drawing.Size(167, 20);
            this.txtCantEjemplares.TabIndex = 5;
            // 
            // txtAnioPublicacion
            // 
            this.txtAnioPublicacion.Location = new System.Drawing.Point(178, 228);
            this.txtAnioPublicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnioPublicacion.Name = "txtAnioPublicacion";
            this.txtAnioPublicacion.Size = new System.Drawing.Size(167, 20);
            this.txtAnioPublicacion.TabIndex = 6;
            // 
            // grpDatosLibros
            // 
            this.grpDatosLibros.Controls.Add(this.cmbGenero);
            this.grpDatosLibros.Controls.Add(this.label6);
            this.grpDatosLibros.Controls.Add(this.label5);
            this.grpDatosLibros.Controls.Add(this.label4);
            this.grpDatosLibros.Controls.Add(this.label3);
            this.grpDatosLibros.Controls.Add(this.label2);
            this.grpDatosLibros.Controls.Add(this.label1);
            this.grpDatosLibros.Controls.Add(this.txtTitulo);
            this.grpDatosLibros.Controls.Add(this.txtAnioPublicacion);
            this.grpDatosLibros.Controls.Add(this.txtISBN);
            this.grpDatosLibros.Controls.Add(this.txtCantEjemplares);
            this.grpDatosLibros.Controls.Add(this.txtAutor);
            this.grpDatosLibros.Location = new System.Drawing.Point(9, 34);
            this.grpDatosLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDatosLibros.Name = "grpDatosLibros";
            this.grpDatosLibros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDatosLibros.Size = new System.Drawing.Size(380, 331);
            this.grpDatosLibros.TabIndex = 7;
            this.grpDatosLibros.TabStop = false;
            this.grpDatosLibros.Text = "Datos del Libro";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Terror",
            "Comedia",
            "Romance",
            "Ciencia ficcion",
            "Aventura"});
            this.cmbGenero.Location = new System.Drawing.Point(178, 153);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(167, 21);
            this.cmbGenero.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Año de Publicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad de Ejemplares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ISBN";
            // 
            // dtgLibros
            // 
            this.dtgLibros.AllowUserToAddRows = false;
            this.dtgLibros.AllowUserToDeleteRows = false;
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Location = new System.Drawing.Point(416, 34);
            this.dtgLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.RowHeadersWidth = 51;
            this.dtgLibros.RowTemplate.Height = 24;
            this.dtgLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLibros.Size = new System.Drawing.Size(474, 208);
            this.dtgLibros.TabIndex = 8;
            this.dtgLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLibros_CellContentClick);
            // 
            // FormLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 428);
            this.Controls.Add(this.dtgLibros);
            this.Controls.Add(this.grpDatosLibros);
            this.Controls.Add(this.btnBajaLibro);
            this.Controls.Add(this.btnAltaLibro);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLibros";
            this.Text = "FormLibros";
            this.Load += new System.EventHandler(this.FormLibros_Load);
            this.grpDatosLibros.ResumeLayout(false);
            this.grpDatosLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaLibro;
        private System.Windows.Forms.Button btnBajaLibro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtCantEjemplares;
        private System.Windows.Forms.TextBox txtAnioPublicacion;
        private System.Windows.Forms.GroupBox grpDatosLibros;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgLibros;
    }
}