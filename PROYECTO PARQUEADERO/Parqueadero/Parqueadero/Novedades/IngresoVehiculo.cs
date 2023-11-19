using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    public partial class IngresoVehiculo : Form
    {
        public IngresoVehiculo()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = DB.conectar("Parqueadero");
            try
            {

                string sqlIngresar = "insert into Clientes values ('" + txCedula.Text + "'," +
                    " '" + txNombre.Text + "', '" + txPlaca.Text + "', " + "' " + txTipoVehiculo.Text + "', " + Int32.Parse(txCelda.Text) + ")";
                int n = DB.operar(sqlIngresar, objConectar);
                if (n == 0)
                {
                    MessageBox.Show("No se puedo ingresar, intenta nuevamente");
                }
                else
                {
                    MessageBox.Show("Ingresado con exito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion " + ex.Message);
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txPlaca.Clear();
            txCedula.Clear();
            txNombre.Clear();
            txTipoVehiculo.Clear();
            txCelda.Clear();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
