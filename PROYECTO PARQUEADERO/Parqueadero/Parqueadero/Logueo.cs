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
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = DB.conectar("Parqueadero");
            SqlDataReader objTabla;
            string usuario = txUsuario.Text;
            string clave = txClave.Text;
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Ingresa la informacion solicitada");
            }
            else
            {
                string sql = "select * from Control_Acceso where Nombre = '" + usuario + "'";
                objTabla = DB.consulta(sql, objConectar);
                if (objTabla.Read())
                {
                    string claveDB = objTabla["Clave"].ToString();
                    int rol = Int32.Parse(objTabla["Rol"].ToString());

                    if (claveDB == clave)
                    {
                        MessageBox.Show("Bienvenido al sistema de informacion restaurante " + usuario);

                        MaestroDetalle objMaestro = new MaestroDetalle(usuario,rol);
                        this.Hide();
                        objMaestro.Show();

                    }
                    else
                    {
                        MessageBox.Show("Clave invalida");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txUsuario.Clear();
            txClave.Clear();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logueo_Load(object sender, EventArgs e)
        {

        }

    }
}
