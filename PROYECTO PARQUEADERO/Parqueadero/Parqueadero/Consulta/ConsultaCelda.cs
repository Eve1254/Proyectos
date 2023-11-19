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
    public partial class ConsultaCelda : Form
    {
        public ConsultaCelda()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = DB.conectar("Parqueadero");
            try
            {
                int cod = Int32.Parse(txCodigo.Text);
                string sqlBuscar = "select * from Celdas where CeldaId = " + cod;
                SqlDataReader objTabla = DB.consulta(sqlBuscar, objConectar);
                if (objTabla.Read())
                {
                    txTipo.Text = objTabla["TipoCelda"].ToString();
                    txEstado.Text = objTabla["EstadoCelda"].ToString();
                }
                else
                {
                    MessageBox.Show("Celda no encontrada");
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
            txCodigo.Clear();
            txTipo.Clear();
            txEstado.Clear();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
