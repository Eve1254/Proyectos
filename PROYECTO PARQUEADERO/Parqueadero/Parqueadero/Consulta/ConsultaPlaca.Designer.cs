namespace Parqueadero
{
    partial class ConsultaPlaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPlaca));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbcod = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbnombre = new System.Windows.Forms.Label();
            this.btBorrar = new System.Windows.Forms.Button();
            this.lbTipo = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txPlaca = new System.Windows.Forms.TextBox();
            this.txTipoVehiculo = new System.Windows.Forms.TextBox();
            this.txCelda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta por Placa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.lbcod);
            this.groupBox1.Controls.Add(this.btRegresar);
            this.groupBox1.Controls.Add(this.lbnombre);
            this.groupBox1.Controls.Add(this.btBorrar);
            this.groupBox1.Controls.Add(this.lbTipo);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.txPlaca);
            this.groupBox1.Controls.Add(this.txTipoVehiculo);
            this.groupBox1.Controls.Add(this.txCelda);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(106, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 162);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lbcod
            // 
            this.lbcod.AutoSize = true;
            this.lbcod.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcod.Location = new System.Drawing.Point(18, 27);
            this.lbcod.Name = "lbcod";
            this.lbcod.Size = new System.Drawing.Size(39, 13);
            this.lbcod.TabIndex = 1;
            this.lbcod.Text = "Placa";
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
            this.lbnombre.Location = new System.Drawing.Point(18, 71);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(43, 13);
            this.lbnombre.TabIndex = 2;
            this.lbnombre.Text = "Celda";
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
            this.lbTipo.Location = new System.Drawing.Point(18, 110);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(97, 13);
            this.lbTipo.TabIndex = 3;
            this.lbTipo.Text = "Tipo Vehículo";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(483, 22);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 9;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txPlaca
            // 
            this.txPlaca.Location = new System.Drawing.Point(121, 22);
            this.txPlaca.Name = "txPlaca";
            this.txPlaca.Size = new System.Drawing.Size(186, 22);
            this.txPlaca.TabIndex = 5;
            // 
            // txTipoVehiculo
            // 
            this.txTipoVehiculo.Enabled = false;
            this.txTipoVehiculo.Location = new System.Drawing.Point(121, 103);
            this.txTipoVehiculo.Name = "txTipoVehiculo";
            this.txTipoVehiculo.Size = new System.Drawing.Size(186, 22);
            this.txTipoVehiculo.TabIndex = 7;
            // 
            // txCelda
            // 
            this.txCelda.Enabled = false;
            this.txCelda.Location = new System.Drawing.Point(121, 66);
            this.txCelda.Name = "txCelda";
            this.txCelda.Size = new System.Drawing.Size(186, 22);
            this.txCelda.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaPlaca";
            this.Text = "ConsultaPlaca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbcod;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txPlaca;
        private System.Windows.Forms.TextBox txTipoVehiculo;
        private System.Windows.Forms.TextBox txCelda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}