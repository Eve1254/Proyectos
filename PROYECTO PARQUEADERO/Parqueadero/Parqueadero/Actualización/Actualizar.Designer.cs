namespace Parqueadero
{
    partial class Actualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btActualizacion = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.Placa = new System.Windows.Forms.TextBox();
            this.txCodigoCelda = new System.Windows.Forms.TextBox();
            this.txTipoVehiculo = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbActualizar = new System.Windows.Forms.GroupBox();
            this.txActualizar = new System.Windows.Forms.TextBox();
            this.cbActualizar = new System.Windows.Forms.ComboBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btBorrarActualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDatos.SuspendLayout();
            this.gbActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btActualizacion);
            this.gbDatos.Controls.Add(this.btBorrar);
            this.gbDatos.Controls.Add(this.btRegresar);
            this.gbDatos.Controls.Add(this.btBuscar);
            this.gbDatos.Controls.Add(this.Placa);
            this.gbDatos.Controls.Add(this.txCodigoCelda);
            this.gbDatos.Controls.Add(this.txTipoVehiculo);
            this.gbDatos.Controls.Add(this.txNombre);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.Cedula);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(103, 93);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(595, 253);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // btActualizacion
            // 
            this.btActualizacion.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizacion.Location = new System.Drawing.Point(464, 83);
            this.btActualizacion.Name = "btActualizacion";
            this.btActualizacion.Size = new System.Drawing.Size(104, 23);
            this.btActualizacion.TabIndex = 14;
            this.btActualizacion.Text = "Actualización";
            this.btActualizacion.UseVisualStyleBackColor = true;
            this.btActualizacion.Click += new System.EventHandler(this.btActualizacion_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(464, 120);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(104, 23);
            this.btBorrar.TabIndex = 13;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(464, 158);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(104, 23);
            this.btRegresar.TabIndex = 12;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(464, 44);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(104, 23);
            this.btBuscar.TabIndex = 11;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Placa
            // 
            this.Placa.Enabled = false;
            this.Placa.Location = new System.Drawing.Point(141, 81);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(189, 20);
            this.Placa.TabIndex = 10;
            // 
            // txCodigoCelda
            // 
            this.txCodigoCelda.Enabled = false;
            this.txCodigoCelda.Location = new System.Drawing.Point(141, 197);
            this.txCodigoCelda.Name = "txCodigoCelda";
            this.txCodigoCelda.Size = new System.Drawing.Size(189, 20);
            this.txCodigoCelda.TabIndex = 9;
            // 
            // txTipoVehiculo
            // 
            this.txTipoVehiculo.Enabled = false;
            this.txTipoVehiculo.Location = new System.Drawing.Point(141, 161);
            this.txTipoVehiculo.Name = "txTipoVehiculo";
            this.txTipoVehiculo.Size = new System.Drawing.Size(189, 20);
            this.txTipoVehiculo.TabIndex = 8;
            // 
            // txNombre
            // 
            this.txNombre.Enabled = false;
            this.txNombre.Location = new System.Drawing.Point(141, 123);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(189, 20);
            this.txNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cédula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Vehículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Celda";
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(141, 41);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(189, 20);
            this.Cedula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Actualizar Clientes";
            // 
            // gbActualizar
            // 
            this.gbActualizar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gbActualizar.Controls.Add(this.txActualizar);
            this.gbActualizar.Controls.Add(this.cbActualizar);
            this.gbActualizar.Controls.Add(this.btActualizar);
            this.gbActualizar.Controls.Add(this.btBorrarActualizar);
            this.gbActualizar.Enabled = false;
            this.gbActualizar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizar.Location = new System.Drawing.Point(103, 373);
            this.gbActualizar.Name = "gbActualizar";
            this.gbActualizar.Size = new System.Drawing.Size(617, 120);
            this.gbActualizar.TabIndex = 28;
            this.gbActualizar.TabStop = false;
            this.gbActualizar.Text = "Ingrese los datos que desea actualizar";
            this.gbActualizar.Visible = false;
            // 
            // txActualizar
            // 
            this.txActualizar.Location = new System.Drawing.Point(20, 70);
            this.txActualizar.Name = "txActualizar";
            this.txActualizar.Size = new System.Drawing.Size(119, 22);
            this.txActualizar.TabIndex = 14;
            // 
            // cbActualizar
            // 
            this.cbActualizar.FormattingEnabled = true;
            this.cbActualizar.Items.AddRange(new object[] {
            "Nombre",
            "Placa",
            "Tipo vehículo",
            "Código Celda"});
            this.cbActualizar.Location = new System.Drawing.Point(20, 34);
            this.cbActualizar.Name = "cbActualizar";
            this.cbActualizar.Size = new System.Drawing.Size(121, 21);
            this.cbActualizar.TabIndex = 13;
            // 
            // btActualizar
            // 
            this.btActualizar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.Location = new System.Drawing.Point(483, 34);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(85, 23);
            this.btActualizar.TabIndex = 12;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btBorrarActualizar
            // 
            this.btBorrarActualizar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrarActualizar.Location = new System.Drawing.Point(483, 70);
            this.btBorrarActualizar.Name = "btBorrarActualizar";
            this.btBorrarActualizar.Size = new System.Drawing.Size(85, 23);
            this.btBorrarActualizar.TabIndex = 10;
            this.btBorrarActualizar.Text = "Borrar";
            this.btBorrarActualizar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(690, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDatos);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbActualizar.ResumeLayout(false);
            this.gbActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox Placa;
        private System.Windows.Forms.TextBox txCodigoCelda;
        private System.Windows.Forms.TextBox txTipoVehiculo;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbActualizar;
        private System.Windows.Forms.TextBox txActualizar;
        private System.Windows.Forms.ComboBox cbActualizar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btBorrarActualizar;
        private System.Windows.Forms.Button btActualizacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}