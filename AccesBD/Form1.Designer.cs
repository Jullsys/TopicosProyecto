namespace AccesoBaseDatos1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.NoCarrera = new System.Windows.Forms.TextBox();
            this.btCrearBD = new System.Windows.Forms.Button();
            this.btCrearTabla = new System.Windows.Forms.Button();
            this.btInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrera";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Location = new System.Drawing.Point(101, 40);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(232, 20);
            this.txtNoControl.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // NoCarrera
            // 
            this.NoCarrera.Location = new System.Drawing.Point(101, 104);
            this.NoCarrera.Name = "NoCarrera";
            this.NoCarrera.Size = new System.Drawing.Size(232, 20);
            this.NoCarrera.TabIndex = 5;
            // 
            // btCrearBD
            // 
            this.btCrearBD.Location = new System.Drawing.Point(506, 43);
            this.btCrearBD.Name = "btCrearBD";
            this.btCrearBD.Size = new System.Drawing.Size(107, 44);
            this.btCrearBD.TabIndex = 6;
            this.btCrearBD.Text = "Crear BD";
            this.btCrearBD.UseVisualStyleBackColor = true;
            this.btCrearBD.Click += new System.EventHandler(this.btCrearBD_Click);
            // 
            // btCrearTabla
            // 
            this.btCrearTabla.Location = new System.Drawing.Point(506, 101);
            this.btCrearTabla.Name = "btCrearTabla";
            this.btCrearTabla.Size = new System.Drawing.Size(107, 46);
            this.btCrearTabla.TabIndex = 7;
            this.btCrearTabla.Text = "Crear Tabla";
            this.btCrearTabla.UseVisualStyleBackColor = true;
            this.btCrearTabla.Click += new System.EventHandler(this.btCrearTabla_Click);
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(224, 162);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(90, 30);
            this.btInsertar.TabIndex = 8;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 227);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.btCrearTabla);
            this.Controls.Add(this.btCrearBD);
            this.Controls.Add(this.NoCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox NoCarrera;
        private System.Windows.Forms.Button btCrearBD;
        private System.Windows.Forms.Button btCrearTabla;
        private System.Windows.Forms.Button btInsertar;
    }
}

