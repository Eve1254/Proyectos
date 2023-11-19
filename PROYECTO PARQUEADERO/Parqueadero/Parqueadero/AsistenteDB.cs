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
    public partial class AsistenteDB : Form
    {
        public AsistenteDB()
        {
            InitializeComponent();
        }

        private void AsistenteDB_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parqueaderoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.parqueaderoDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'parqueaderoDataSet.Celdas' Puede moverla o quitarla según sea necesario.
            this.celdasTableAdapter.Fill(this.parqueaderoDataSet.Celdas);

        }
    }
}
