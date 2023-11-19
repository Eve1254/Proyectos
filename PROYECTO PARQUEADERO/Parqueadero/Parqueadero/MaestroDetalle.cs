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
    public partial class MaestroDetalle : Form
    {
        string us;
        int rol;
        public MaestroDetalle(string us, int rol)
        {
            InitializeComponent();
            this.us = us;
            this.rol = rol;
            this.Text = "Sistema Parqueadero " + us;
                if (rol == 2)
                {
                actualizacionesToolStripMenuItem.Enabled = false;
                celdasToolStripMenuItem.Enabled = false;
                clientesToolStripMenuItem.Enabled = false;
                asistenteMaestroDetalleToolStripMenuItem.Enabled = false;
                }
        }

        private void celdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCelda objConsultaCelda = new ConsultaCelda();
            objConsultaCelda.MdiParent = this;
            objConsultaCelda.Show();
        }

        private void placaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPlaca objConsultaPlaca = new ConsultaPlaca();
            objConsultaPlaca.MdiParent = this;
            objConsultaPlaca.Show();
        }

        private void ingresoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarCliente objIngresarCliente = new IngresarCliente();
            objIngresarCliente.MdiParent = this;
            objIngresarCliente.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente objEliminarCliente = new EliminarCliente();
            objEliminarCliente.MdiParent = this;
            objEliminarCliente.Show();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar objActualizarCliente = new Actualizar();
            objActualizarCliente.MdiParent = this;
            objActualizarCliente.Show();
        }

        private void ingresarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoVehiculo objIngresoVehiculo = new IngresoVehiculo();
            objIngresoVehiculo.MdiParent = this;
            objIngresoVehiculo.Show();
        }

        private void celdasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenteCeldas objAsistenteCeldas = new AsistenteCeldas();
            objAsistenteCeldas.MdiParent = this;
            objAsistenteCeldas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenteClientes objAsistenteClientes = new AsistenteClientes();
            objAsistenteClientes.MdiParent = this;
            objAsistenteClientes.Show();
        }

        private void asistenteDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenteDB objAsistenteDB = new AsistenteDB();
            objAsistenteDB.MdiParent = this;
            objAsistenteDB.Show();
        }

        private void salidaVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalidaVehiculo objSalidaVehiculo = new SalidaVehiculo();
            objSalidaVehiculo.MdiParent = this;
            objSalidaVehiculo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
