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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = DB.conectar("Parqueadero");
            try
            {
                string sqlBuscar = "select * from Clientes where Cedula= '" + Cedula.Text + "'";
                SqlDataReader objTabla = DB.consulta(sqlBuscar, objConectar);
                if (objTabla.Read())
                {
                    Placa.Text = objTabla["Placa"].ToString();
                    txNombre.Text = objTabla["Nombre"].ToString();
                    txTipoVehiculo.Text = objTabla["TipoVehiculo"].ToString();
                    txCodigoCelda.Text = objTabla["CodigoCelda"].ToString();
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

        private void btActualizacion_Click(object sender, EventArgs e)
        {
            gbActualizar.Visible = true;
            gbActualizar.Enabled = true;
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = DB.conectar("Parqueadero");
            string sql = "";
            switch (cbActualizar.Text)
            {
                case "Nombre":
                    sql = "update Clientes set Nombre =" + " '" + txActualizar.Text + "'" +
                          "where Cedula =" + Cedula.Text;
                    break;

                case "Placa":
                    sql = "update Clientes set Placa =" + " '" + txActualizar.Text + "'" +
                        "where Cedula =" + Cedula.Text;
                    break;

                case "Tipo vehiculo":
                    sql = "update Clientes set TipoVehiculo =" + txActualizar.Text +
                          "where Cedula =" + Cedula.Text;
                    break;

                case "Codigo Celda":
                    sql = "update Clientes set CodigoCelda =" + Int32.Parse(txActualizar.Text) +
                          "where Cedula =" + Cedula.Text;
                    break;
            }
            int n = DB.operar(sql, objConector);
            if (n == 0)
            {
                MessageBox.Show("Los datos no fueron actualizados");
            }
            else
            {
                MessageBox.Show("Los datos fueron actualizados");
            }
            DB.cerrar(objConector);
            Cedula.Clear();
            Placa.Clear();
            txNombre.Clear();
            txTipoVehiculo.Clear();
            txCodigoCelda.Clear();
            txActualizar.Clear();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            Cedula.Clear();
            Placa.Clear();
            txNombre.Clear();
            txTipoVehiculo.Clear();
            txCodigoCelda.Clear();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
