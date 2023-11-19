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
    public partial class SalidaVehiculo : Form
    {
        public SalidaVehiculo()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = DB.conectar("Parqueadero");
            try
            {
                string sqlBuscar = "select * from Clientes where Placa= '" + txPlaca.Text + "'";
                SqlDataReader objTabla = DB.consulta(sqlBuscar, objConectar);
                if (objTabla.Read())
                {
                    txCedula.Text = objTabla["Cedula"].ToString();
                    txNombre.Text = objTabla["Nombre"].ToString();
                    txTipoVehiculo.Text = objTabla["TipoVehiculo"].ToString();
                    txCodigoPlaca.Text = objTabla["CodigoCelda"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion");
            }
            DB.cerrar(objConectar);
        }

        private void btFacturacion_Click(object sender, EventArgs e)
        {
            gbSalir.Visible = true;
            gbSalir.Enabled = true;
            gbSalida.Enabled = false;
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            int ValorTotal = 0;
            if (txTipoVehiculo.Text == " Camioneta " || txTipoVehiculo.Text == " Automovil ")
            {
                ValorTotal = Int32.Parse(txHoras.Text) * 3000;
            }
            else if (txTipoVehiculo.Text == "Moto")
            {
                ValorTotal = Int32.Parse(txHoras.Text) * 1000;
            }
            else if (txTipoVehiculo.Text == "Bus")
            {
                ValorTotal = Int32.Parse(txHoras.Text) * 4000;
            }
            else if (txTipoVehiculo.Text == "Bicicleta")
            {
                ValorTotal = Int32.Parse(txHoras.Text) * 2000;
            }

            txFactura.Text = "\r\n Total: " + ValorTotal;
        }

        private void btSalida_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = DB.conectar("Parqueadero");
            try
            {
                string sqlEliminar = "delete from Clientes where Placa= '" + txPlaca.Text + "'";
                int n = DB.operar(sqlEliminar, objConectar);

                if (n == 0)
                {
                    MessageBox.Show("No se pudo eliminar, intenta nuevamente");
                }
                else
                {
                    MessageBox.Show("El vehículo se ha eliminado exitosamente");
                    txPlaca.Clear();
                    txCedula.Clear();
                    txNombre.Clear();
                    txTipoVehiculo.Clear();
                    txCodigoPlaca.Clear();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexion");
            }
            DB.cerrar(objConectar);
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txPlaca.Clear();
            txCedula.Clear();
            txNombre.Clear();
            txTipoVehiculo.Clear();
            txCodigoPlaca.Clear();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txHoras.Clear();
            txFactura.Clear();
        }

        private void txHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txTipoVehiculo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
