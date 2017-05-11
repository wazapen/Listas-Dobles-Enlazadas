namespace Lista_Doble_Enlazada
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
            this.btnReporteInverso = new System.Windows.Forms.Button();
            this.btnAgregarEnInicio = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosición = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.btnBorrarPrimero = new System.Windows.Forms.Button();
            this.btnBorrarÚltimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReporteInverso
            // 
            this.btnReporteInverso.Location = new System.Drawing.Point(4, 142);
            this.btnReporteInverso.Name = "btnReporteInverso";
            this.btnReporteInverso.Size = new System.Drawing.Size(75, 23);
            this.btnReporteInverso.TabIndex = 48;
            this.btnReporteInverso.Text = "Reporte Inv";
            this.btnReporteInverso.UseVisualStyleBackColor = true;
            this.btnReporteInverso.Click += new System.EventHandler(this.btnReporteInverso_Click);
            // 
            // btnAgregarEnInicio
            // 
            this.btnAgregarEnInicio.Location = new System.Drawing.Point(4, 171);
            this.btnAgregarEnInicio.Name = "btnAgregarEnInicio";
            this.btnAgregarEnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEnInicio.TabIndex = 47;
            this.btnAgregarEnInicio.Text = "Agregar First";
            this.btnAgregarEnInicio.UseVisualStyleBackColor = true;
            this.btnAgregarEnInicio.Click += new System.EventHandler(this.btnAgregarEnInicio_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(85, 113);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(180, 145);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(100, 101);
            this.txtReporte.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Código";
            // 
            // txtPosición
            // 
            this.txtPosición.Location = new System.Drawing.Point(180, 115);
            this.txtPosición.Name = "txtPosición";
            this.txtPosición.Size = new System.Drawing.Size(100, 20);
            this.txtPosición.TabIndex = 41;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(85, 229);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 40;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(85, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(85, 171);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 38;
            this.btnInsertar.Text = "Instertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(85, 142);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 37;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(74, 87);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 35;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(74, 61);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(74, 9);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(100, 20);
            this.txtCódigo.TabIndex = 32;
            // 
            // btnBorrarPrimero
            // 
            this.btnBorrarPrimero.Location = new System.Drawing.Point(4, 200);
            this.btnBorrarPrimero.Name = "btnBorrarPrimero";
            this.btnBorrarPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarPrimero.TabIndex = 49;
            this.btnBorrarPrimero.Text = "Borrar First";
            this.btnBorrarPrimero.UseVisualStyleBackColor = true;
            this.btnBorrarPrimero.Click += new System.EventHandler(this.btnBorrarPrimero_Click);
            // 
            // btnBorrarÚltimo
            // 
            this.btnBorrarÚltimo.Location = new System.Drawing.Point(4, 229);
            this.btnBorrarÚltimo.Name = "btnBorrarÚltimo";
            this.btnBorrarÚltimo.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarÚltimo.TabIndex = 50;
            this.btnBorrarÚltimo.Text = "Borrar Last";
            this.btnBorrarÚltimo.UseVisualStyleBackColor = true;
            this.btnBorrarÚltimo.Click += new System.EventHandler(this.btnBorrarÚltimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBorrarÚltimo);
            this.Controls.Add(this.btnBorrarPrimero);
            this.Controls.Add(this.btnReporteInverso);
            this.Controls.Add(this.btnAgregarEnInicio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosición);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCódigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporteInverso;
        private System.Windows.Forms.Button btnAgregarEnInicio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosición;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.Button btnBorrarPrimero;
        private System.Windows.Forms.Button btnBorrarÚltimo;
    }
}

