namespace Parqueadero
{
    partial class AsistenteDB
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.parqueaderoDataSet = new Parqueadero.ParqueaderoDataSet();
            this.celdasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celdasTableAdapter = new Parqueadero.ParqueaderoDataSetTableAdapters.CeldasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fKClientesCodigo3C69FB99BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Parqueadero.ParqueaderoDataSetTableAdapters.ClientesTableAdapter();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCeldaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.parqueaderoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celdasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClientesCodigo3C69FB99BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una celda:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.celdasBindingSource;
            this.comboBox1.DisplayMember = "CeldaId";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "CeldaId";
            // 
            // parqueaderoDataSet
            // 
            this.parqueaderoDataSet.DataSetName = "ParqueaderoDataSet";
            this.parqueaderoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celdasBindingSource
            // 
            this.celdasBindingSource.DataMember = "Celdas";
            this.celdasBindingSource.DataSource = this.parqueaderoDataSet;
            // 
            // celdasTableAdapter
            // 
            this.celdasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.tipoVehiculoDataGridViewTextBoxColumn,
            this.codigoCeldaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKClientesCodigo3C69FB99BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // fKClientesCodigo3C69FB99BindingSource
            // 
            this.fKClientesCodigo3C69FB99BindingSource.DataMember = "FK__Clientes__Codigo__3C69FB99";
            this.fKClientesCodigo3C69FB99BindingSource.DataSource = this.celdasBindingSource;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            // 
            // codigoCeldaDataGridViewTextBoxColumn
            // 
            this.codigoCeldaDataGridViewTextBoxColumn.DataPropertyName = "CodigoCelda";
            this.codigoCeldaDataGridViewTextBoxColumn.HeaderText = "CodigoCelda";
            this.codigoCeldaDataGridViewTextBoxColumn.Name = "codigoCeldaDataGridViewTextBoxColumn";
            // 
            // AsistenteDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 277);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "AsistenteDB";
            this.Text = "AsistenteDB";
            this.Load += new System.EventHandler(this.AsistenteDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parqueaderoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celdasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClientesCodigo3C69FB99BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ParqueaderoDataSet parqueaderoDataSet;
        private System.Windows.Forms.BindingSource celdasBindingSource;
        private ParqueaderoDataSetTableAdapters.CeldasTableAdapter celdasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKClientesCodigo3C69FB99BindingSource;
        private ParqueaderoDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCeldaDataGridViewTextBoxColumn;
    }
}