
namespace ProyectoFinal
{
    partial class Libros
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
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            this.grpDatosLibros = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAnioPublicacion = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtCantEjemplares = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnBajaLibro = new System.Windows.Forms.Button();
            this.btnAltaLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            this.grpDatosLibros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgLibros
            // 
            this.dtgLibros.AllowUserToAddRows = false;
            this.dtgLibros.AllowUserToDeleteRows = false;
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Location = new System.Drawing.Point(555, 11);
            this.dtgLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.RowHeadersWidth = 51;
            this.dtgLibros.RowTemplate.Height = 24;
            this.dtgLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLibros.Size = new System.Drawing.Size(632, 256);
            this.dtgLibros.TabIndex = 16;
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
            this.grpDatosLibros.Location = new System.Drawing.Point(12, 11);
            this.grpDatosLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosLibros.Name = "grpDatosLibros";
            this.grpDatosLibros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosLibros.Size = new System.Drawing.Size(507, 407);
            this.grpDatosLibros.TabIndex = 15;
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
            this.cmbGenero.Location = new System.Drawing.Point(237, 188);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(221, 24);
            this.cmbGenero.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Año de Publicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad de Ejemplares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ISBN";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(237, 98);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(221, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtAnioPublicacion
            // 
            this.txtAnioPublicacion.Location = new System.Drawing.Point(237, 281);
            this.txtAnioPublicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnioPublicacion.Name = "txtAnioPublicacion";
            this.txtAnioPublicacion.Size = new System.Drawing.Size(221, 22);
            this.txtAnioPublicacion.TabIndex = 6;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(237, 47);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(221, 22);
            this.txtISBN.TabIndex = 2;
            // 
            // txtCantEjemplares
            // 
            this.txtCantEjemplares.Location = new System.Drawing.Point(237, 234);
            this.txtCantEjemplares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantEjemplares.Name = "txtCantEjemplares";
            this.txtCantEjemplares.Size = new System.Drawing.Size(221, 22);
            this.txtCantEjemplares.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(237, 150);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(221, 22);
            this.txtAutor.TabIndex = 4;
            // 
            // btnBajaLibro
            // 
            this.btnBajaLibro.Location = new System.Drawing.Point(951, 291);
            this.btnBajaLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBajaLibro.Name = "btnBajaLibro";
            this.btnBajaLibro.Size = new System.Drawing.Size(160, 126);
            this.btnBajaLibro.TabIndex = 14;
            this.btnBajaLibro.Text = "Dar de Baja";
            this.btnBajaLibro.UseVisualStyleBackColor = true;
            this.btnBajaLibro.Click += new System.EventHandler(this.btnBajaLibro_Click);
            // 
            // btnAltaLibro
            // 
            this.btnAltaLibro.Location = new System.Drawing.Point(661, 291);
            this.btnAltaLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaLibro.Name = "btnAltaLibro";
            this.btnAltaLibro.Size = new System.Drawing.Size(184, 126);
            this.btnAltaLibro.TabIndex = 13;
            this.btnAltaLibro.Text = "Dar de Alta";
            this.btnAltaLibro.UseVisualStyleBackColor = true;
            this.btnAltaLibro.Click += new System.EventHandler(this.btnAltaLibro_Click);
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 446);
            this.Controls.Add(this.dtgLibros);
            this.Controls.Add(this.grpDatosLibros);
            this.Controls.Add(this.btnBajaLibro);
            this.Controls.Add(this.btnAltaLibro);
            this.Name = "Libros";
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            this.grpDatosLibros.ResumeLayout(false);
            this.grpDatosLibros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLibros;
        private System.Windows.Forms.GroupBox grpDatosLibros;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAnioPublicacion;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtCantEjemplares;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnBajaLibro;
        private System.Windows.Forms.Button btnAltaLibro;
    }
}