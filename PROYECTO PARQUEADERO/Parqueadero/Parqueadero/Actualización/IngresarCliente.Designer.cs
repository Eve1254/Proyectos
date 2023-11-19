namespace Parqueadero
{
    partial class IngresarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txCodigoCelda = new System.Windows.Forms.TextBox();
            this.txTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcod = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbnombre = new System.Windows.Forms.Label();
            this.btBorrar = new System.Windows.Forms.Button();
            this.lbTipo = new System.Windows.Forms.Label();
            this.btIngresar = new System.Windows.Forms.Button();
            this.txCedula = new System.Windows.Forms.TextBox();
            this.txPlaca = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Cliente";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txCodigoCelda);
            this.gbDatos.Controls.Add(this.txTipoVehiculo);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.lbcod);
            this.gbDatos.Controls.Add(this.btRegresar);
            this.gbDatos.Controls.Add(this.lbnombre);
            this.gbDatos.Controls.Add(this.btBorrar);
            this.gbDatos.Controls.Add(this.lbTipo);
            this.gbDatos.Controls.Add(this.btIngresar);
            this.gbDatos.Controls.Add(this.txCedula);
            this.gbDatos.Controls.Add(this.txPlaca);
            this.gbDatos.Controls.Add(this.txNombre);
            this.gbDatos.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(117, 91);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(579, 251);
            this.gbDatos.TabIndex = 16;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codigo Celda";
            // 
            // txCodigoCelda
            // 
            this.txCodigoCelda.Location = new System.Drawing.Point(121, 197);
            this.txCodigoCelda.Name = "txCodigoCelda";
            this.txCodigoCelda.Size = new System.Drawing.Size(186, 22);
            this.txCodigoCelda.TabIndex = 14;
            // 
            // txTipoVehiculo
            // 
            this.txTipoVehiculo.Location = new System.Drawing.Point(121, 150);
            this.txTipoVehiculo.Name = "txTipoVehiculo";
            this.txTipoVehiculo.Size = new System.Drawing.Size(186, 22);
            this.txTipoVehiculo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo Vehículo";
            // 
            // lbcod
            // 
            this.lbcod.AutoSize = true;
            this.lbcod.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcod.Location = new System.Drawing.Point(17, 27);
            this.lbcod.Name = "lbcod";
            this.lbcod.Size = new System.Drawing.Size(51, 13);
            this.lbcod.TabIndex = 1;
            this.lbcod.Text = "Cédula";
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(483, 110);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(75, 23);
            this.btRegresar.TabIndex = 11;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(17, 71);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(58, 13);
            this.lbnombre.TabIndex = 2;
            this.lbnombre.Text = "Nombre";
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(483, 66);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(17, 110);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(39, 13);
            this.lbTipo.TabIndex = 3;
            this.lbTipo.Text = "Placa";
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(483, 22);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(75, 23);
            this.btIngresar.TabIndex = 9;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txCedula
            // 
            this.txCedula.Location = new System.Drawing.Point(121, 22);
            this.txCedula.Name = "txCedula";
            this.txCedula.Size = new System.Drawing.Size(186, 22);
            this.txCedula.TabIndex = 5;
            // 
            // txPlaca
            // 
            this.txPlaca.Location = new System.Drawing.Point(121, 103);
            this.txPlaca.Name = "txPlaca";
            this.txPlaca.Size = new System.Drawing.Size(186, 22);
            this.txPlaca.TabIndex = 7;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(121, 66);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(186, 22);
            this.txNombre.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // IngresarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label1);
            this.Name = "IngresarCliente";
            this.Text = "IngresarCliente";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lbcod;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.TextBox txCedula;
        private System.Windows.Forms.TextBox txPlaca;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCodigoCelda;
        private System.Windows.Forms.TextBox txTipoVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}