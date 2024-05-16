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


            return conexionDAL.EjecutarComandoSinRetornoDatos("INSERT INTO ORDENINTERNA (numeroOrden_OI, numIngreso_OI, NumRegistro_OI, observaciones_OI, FechaRecepcion_OI, FechaTermino_OI, FechaElavoracion_OI, Magnitud, DiasFaltantes_OI, idEmpleado, idVendedor)\r\nVALUES (\r\n    @NoIO,\r\n    'valor_para_numIngreso_OI', -- Asumiendo que este valor lo obtienes de alguna manera\r\n    @NoRegistro_Asisgnado,\r\n    @Observaciones_GeneralesOI,\r\n    @FechaElaboracionIO,\r\n    @Fecha_Recepcion,\r\n    @Fecha_Termino_Servicio,\r\n    (SELECT Magnitud FROM EQUIPO WHERE idEquipo = @idEquipo), -- Obtener la magnitud del equipo usando su id\r\n    @DiasParaLaEntrega,\r\n    (SELECT idEmpleado FROM EMPLEADO WHERE NombreCompleto = @ElaboroIO), -- Obtener el id del empleado usando su nombre completo\r\n    (SELECT idVendedor FROM VENDEDOR WHERE NOMBRE = @Vendedor) -- Obtener el id del vendedor usando su nombre\r\n);\r\n\r\n-- Insertar en la tabla CLIENTE\r\nINSERT INTO CLIENTE (NombreEmpresa, Direccion, atencion)\r\nVALUES (\r\n    @NombreClienteE,\r\n    @DireccionClienteE,\r\n    @AtencionClienteE\r\n);\r\n\r\n-- Insertar en la tabla DETALLEORDEN\r\nINSERT INTO DETALLEORDEN (idEquipo, idCliente, numeroOrden_OI)\r\nVALUES (\r\n    @idEquipo,\r\n    (SELECT idCliente FROM CLIENTE WHERE NombreEmpresa = @NombreClienteE), -- Obtener el id del cliente usando el nombre de la empresa\r\n    @NoIO\r\n);");
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

        public DataSet MostrarAOI()
        {
            SqlCommand sentencia = new SqlCommand("SELECT     oi.numeroOrden_OI AS 'NoIO',    oi.NumRegistro_OI AS 'NoRegistro_Asisgnado',   oi.FechaElavoracion_OI AS 'FechaElaboracionIO',    oi.DiasFaltantes_OI AS 'DiasParaLaEntrega',    e.Magnitud AS 'Magnitud',   oi.FechaRecepcion_OI AS 'Fecha_Recepcion',   oi.FechaTermino_OI AS 'Fecha_Termino_Servicio',    v.NOMBRE AS 'Vendedor',    emp.NombreCompleto AS 'ElaboroIO',   f.Foto1 AS 'fotoEquipo',    c.NombreEmpresa AS 'NombreClienteE',   c.Direccion AS 'DireccionClienteE',    c.atencion AS 'AtencionClienteE',    oi.observaciones_OI AS 'Observaciones_GeneralesOI' FROM    ORDENINTERNA oi     INNER JOIN EQUIPO e ON oi.Magnitud = e.Magnitud -- Asumiendo que se relacionan por el campo Magnitud    INNER JOIN VENDEDOR v ON oi.idVendedor = v.idVendedor    INNER JOIN EMPLEADO emp ON oi.idEmpleado = emp.idEmpleado   INNER JOIN CLIENTE c ON c.idCliente = (SELECT idCliente FROM DETALLEORDEN WHERE numeroOrden_OI = oi.numeroOrden_OI) -- Obteniendo el idCliente relacionado a través de DETALLEORDEN   INNER JOIN FOTOS f ON f.idFotos = (SELECT idFotos FROM DETALLE WHERE idEquipo = e.idEquipo) -- Obteniendo las fotos del equipo");
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


        public DataSet MostrarOI_Todo()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM ???");
            return conexionDAL.EjecutarSentencia(sentencia);
        }
    }
}
