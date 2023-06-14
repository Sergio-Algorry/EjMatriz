namespace frontend
{
    partial class frmABMLista
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btModificarOri = new System.Windows.Forms.Button();
            this.txtNombreOri = new System.Windows.Forms.TextBox();
            this.lblNombreOri = new System.Windows.Forms.Label();
            this.txtNombreNue = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btBorrar = new System.Windows.Forms.Button();
            this.lblNombreNue = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(184, 26);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificarOri
            // 
            this.btModificarOri.Location = new System.Drawing.Point(381, 72);
            this.btModificarOri.Name = "btModificarOri";
            this.btModificarOri.Size = new System.Drawing.Size(75, 23);
            this.btModificarOri.TabIndex = 5;
            this.btModificarOri.Text = "Modificar";
            this.btModificarOri.UseVisualStyleBackColor = true;
            this.btModificarOri.Click += new System.EventHandler(this.btModificarOri_Click);
            // 
            // txtNombreOri
            // 
            this.txtNombreOri.Location = new System.Drawing.Point(16, 75);
            this.txtNombreOri.Name = "txtNombreOri";
            this.txtNombreOri.Size = new System.Drawing.Size(161, 20);
            this.txtNombreOri.TabIndex = 4;
            // 
            // lblNombreOri
            // 
            this.lblNombreOri.AutoSize = true;
            this.lblNombreOri.Location = new System.Drawing.Point(13, 58);
            this.lblNombreOri.Name = "lblNombreOri";
            this.lblNombreOri.Size = new System.Drawing.Size(94, 13);
            this.lblNombreOri.TabIndex = 3;
            this.lblNombreOri.Text = "Nombre a Cambiar";
            // 
            // txtNombreNue
            // 
            this.txtNombreNue.Location = new System.Drawing.Point(184, 75);
            this.txtNombreNue.Name = "txtNombreNue";
            this.txtNombreNue.Size = new System.Drawing.Size(161, 20);
            this.txtNombreNue.TabIndex = 6;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(265, 26);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(2, 181);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(644, 27);
            this.lblMensaje.TabIndex = 12;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(381, 26);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 13;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // lblNombreNue
            // 
            this.lblNombreNue.AutoSize = true;
            this.lblNombreNue.Location = new System.Drawing.Point(181, 58);
            this.lblNombreNue.Name = "lblNombreNue";
            this.lblNombreNue.Size = new System.Drawing.Size(77, 13);
            this.lblNombreNue.TabIndex = 14;
            this.lblNombreNue.Text = "Nombre nuevo";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(456, 13);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(0, 13);
            this.lblSalida.TabIndex = 15;
            // 
            // frmABMLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 208);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblNombreNue);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtNombreNue);
            this.Controls.Add(this.btModificarOri);
            this.Controls.Add(this.txtNombreOri);
            this.Controls.Add(this.lblNombreOri);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmABMLista";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btModificarOri;
        private System.Windows.Forms.TextBox txtNombreOri;
        private System.Windows.Forms.Label lblNombreOri;
        private System.Windows.Forms.TextBox txtNombreNue;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lblNombreNue;
        private System.Windows.Forms.Label lblSalida;
    }
}

