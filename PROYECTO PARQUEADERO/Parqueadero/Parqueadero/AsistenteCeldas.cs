using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    public partial class AsistenteCeldas : Form
    {
        public AsistenteCeldas()
        {
            InitializeComponent();
        }

        private void AsistenteCeldas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parqueaderoDataSet.Celdas' Puede moverla o quitarla según sea necesario.
            this.celdasTableAdapter.Fill(this.parqueaderoDataSet.Celdas);

        }

        private void celdasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.celdasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parqueaderoDataSet);

        }
    }
}
