namespace ProyectoFinal
{
    partial class Redireccionamiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltasBajasLibros = new System.Windows.Forms.Button();
            this.btnCubiculo_Individual = new System.Windows.Forms.Button();
            this.btnCubiculoEquipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que desea realizar?";
            // 
            // btnAltasBajasLibros
            // 
            this.btnAltasBajasLibros.Location = new System.Drawing.Point(43, 77);
            this.btnAltasBajasLibros.Name = "btnAltasBajasLibros";
            this.btnAltasBajasLibros.Size = new System.Drawing.Size(149, 66);
            this.btnAltasBajasLibros.TabIndex = 1;
            this.btnAltasBajasLibros.Text = "Altas/Bajas de Libros";
            this.btnAltasBajasLibros.UseVisualStyleBackColor = true;
            this.btnAltasBajasLibros.Click += new System.EventHandler(this.btnAltasBajasLibros_Click);
            // 
            // btnCubiculo_Individual
            // 
            this.btnCubiculo_Individual.Location = new System.Drawing.Point(43, 166);
            this.btnCubiculo_Individual.Name = "btnCubiculo_Individual";
            this.btnCubiculo_Individual.Size = new System.Drawing.Size(149, 68);
            this.btnCubiculo_Individual.TabIndex = 2;
            this.btnCubiculo_Individual.Text = "Control de Cubiculos Individuales";
            this.btnCubiculo_Individual.UseVisualStyleBackColor = true;
            this.btnCubiculo_Individual.Click += new System.EventHandler(this.btnCubiculo_Individual_Click);
            // 
            // btnCubiculoEquipo
            // 
            this.btnCubiculoEquipo.Location = new System.Drawing.Point(279, 77);
            this.btnCubiculoEquipo.Name = "btnCubiculoEquipo";
            this.btnCubiculoEquipo.Size = new System.Drawing.Size(162, 66);
            this.btnCubiculoEquipo.TabIndex = 3;
            this.btnCubiculoEquipo.Text = "Control de Cubiculos para Equipos";
            this.btnCubiculoEquipo.UseVisualStyleBackColor = true;
            this.btnCubiculoEquipo.Click += new System.EventHandler(this.btnCubiculoEquipo_Click);
            // 
            // Redireccionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 281);
            this.Controls.Add(this.btnCubiculoEquipo);
            this.Controls.Add(this.btnCubiculo_Individual);
            this.Controls.Add(this.btnAltasBajasLibros);
            this.Controls.Add(this.label1);
            this.Name = "Redireccionamiento";
            this.Text = "Redireccionamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltasBajasLibros;
        private System.Windows.Forms.Button btnCubiculo_Individual;
        private System.Windows.Forms.Button btnCubiculoEquipo;
    }
}