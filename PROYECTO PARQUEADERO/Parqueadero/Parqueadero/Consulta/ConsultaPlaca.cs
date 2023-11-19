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
    public partial class ConsultaPlaca : Form
    {
        public ConsultaPlaca()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            txPlaca.Focus();
            SqlConnection objConectar = DB.conectar("Parqueadero");
            try
            {
                string sqlBuscar = "select * from Clientes where Placa= '" + txPlaca.Text + "'";
                SqlDataReader objTabla = DB.consulta(sqlBuscar, objConectar);
                if (objTabla.Read())
                {
                    txCelda.Text = objTabla["CodigoCelda"].ToString();
                    txTipoVehiculo.Text = objTabla["TipoVehiculo"].ToString();
                }
                else
                {
                    MessageBox.Show("Placa no encontrada");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex.Message);
            }
            DB.cerrar(objConectar);
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txPlaca.Clear();
            txCelda.Clear();
            txTipoVehiculo.Clear();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
