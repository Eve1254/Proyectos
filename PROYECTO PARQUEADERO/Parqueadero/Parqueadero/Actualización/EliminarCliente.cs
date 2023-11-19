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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
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
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex.Message);
            }
            DB.cerrar(objConectar);
        }

        private void btEliminar_Click(object sender, EventArgs e)
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
                    MessageBox.Show("El cliente se ha eliminado exitosamente");
                    txPlaca.Clear();
                    txCedula.Clear();
                    txNombre.Clear();
                    txTipoVehiculo.Clear();
                    txCodigoPlaca.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexion" + ex.Message);
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
    }
}
