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
    internal class Orden_InternaDAL
    {
        ConexionDAL conexionDAL;

        public Orden_InternaDAL()
        {
            conexionDAL = new ConexionDAL();
        }

        public bool AgregarOI(Orden_InternaBLL oOrden_InternaBLL) {

            SqlCommand sqlCommand = new SqlCommand("");

            // Campos de la BD

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public bool ModificarOI(Orden_InternaBLL oOrden_InternaBLL)
        {

            SqlCommand sqlCommand = new SqlCommand("");

            // Campos de la BD

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public bool EliminarOI(Orden_InternaBLL oOrden_InternaBLL)
        {

            SqlCommand sqlCommand = new SqlCommand("");

            // Campos de la BD

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public DataSet MostrarOI()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM ???");
            return conexionDAL.EjecutarSentencia(sentencia);
        }


        //tabla
        public bool AgregarOI_Tabla(Orden_InternaBLL oOrden_InternaBLL)
        {

            SqlCommand sqlCommand = new SqlCommand("");

            // Campos de la BD

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public bool ModificarOI_Tabla(Orden_InternaBLL oOrden_InternaBLL)
        {

            SqlCommand sqlCommand = new SqlCommand("");

            // Campos de la BD

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public bool EliminarOI_Tabla (Orden_InternaBLL oOrden_InternaBLL)
        {

            SqlCommand sqlCommand = new SqlCommand("");

            // Campos de la BD

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public DataSet MostrarOI_Tabla()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM ???");
            return conexionDAL.EjecutarSentencia(sentencia);
        }
    }
}
