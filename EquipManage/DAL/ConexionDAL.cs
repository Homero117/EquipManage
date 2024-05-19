using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipManage.DAL
{
    internal class ConexionDAL
    {
        private string CadenaConexion = "Data Source=HOMERO_JPC;Initial Catalog=PROYECTO_INTEGRADOR_5;Integrated Security=True"; 
        SqlConnection connection;

        public SqlConnection EstablecerConexion()
        {
            this.connection = new SqlConnection(this.CadenaConexion);
            return this.connection;
        }
        public bool EjecutarComandoSinRetornoDatos(string strComando)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = strComando;
                comando.Connection = this.EstablecerConexion();
                connection.Open();
                comando.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool EjecutarComandoSinRetornoDatos(SqlCommand SQLComando)
        {
            try
            {
                SqlCommand comando = SQLComando;
                comando.Connection = this.EstablecerConexion();
                connection.Open();
                comando.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = Comando;
                connection.Open();
                Adaptador.Fill(DS);
                connection.Close();
                return DS;
            }
            catch
            {
                return DS;
            }
        }
    }
}
