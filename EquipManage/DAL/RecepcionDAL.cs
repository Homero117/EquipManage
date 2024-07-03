using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EquipManage.BLL;

namespace EquipManage.DAL
{
    internal class RecepcionDAL
    {
        ConexionDAL conexionDAL;

        public RecepcionDAL()
        {
            conexionDAL = new ConexionDAL();

        }

        public bool AgregarR(RecepcionBLL oRecepcionBLL) {
            SqlCommand sqlCommand = new SqlCommand("");

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public bool EliminarR(RecepcionBLL oRecepcionBLL)
        {
            SqlCommand sqlCommand = new SqlCommand("");

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public bool ModificarR(RecepcionBLL oRecepcionBLL)
        {
            SqlCommand sqlCommand = new SqlCommand("");

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);

        }

        public DataSet MostrarR()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM ??");
            return conexionDAL.EjecutarSentencia(sentencia);
        }

        public DataSet MostrarEquipo()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Equipo;");
            return conexionDAL.EjecutarSentencia(sentencia);
        }

    }


}
