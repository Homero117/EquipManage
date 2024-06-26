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

        public bool AgregarOIClente(Orden_InternaBLL oOrden_InternaBLL)
        {


            return conexionDAL.EjecutarComandoSinRetornoDatos("insert into Cliente (Id_Cliente, Nombre, Direccion, Atencion) values (" + oOrden_InternaBLL.NoIO + ",'" + oOrden_InternaBLL.NombreClienteE + "', '" + oOrden_InternaBLL.DireccionClienteE + "', '" + oOrden_InternaBLL.AtencionClienteE + "'); ");
            //  "insert into Equipo (Id_Equipo, No_Ingreso, Tipo_Servicio, Nombre_Equipo, Marca, Codigo_Fabricante, Num_Serie, Identificacion, Intervalo, Resolucion, Grado_ClaseEscala, Accesorios, Observaciones, Material, No_Parte, No_Plano, No_Cotas, No_Piezas, Id_Foto, Id_Cliente) values (" + oOrden_InternaBLL.NoIOT + ", " + oOrden_InternaBLL.NoIngresoT + ", '" + oOrden_InternaBLL.TipoServicio + "', '" + oOrden_InternaBLL.Equipo + "', '" + oOrden_InternaBLL.Marca_Modelo + "', '" + oOrden_InternaBLL.CodFabricante + "', '" + oOrden_InternaBLL.Serie + "', '" + oOrden_InternaBLL.Identificador + "', '" + oOrden_InternaBLL.Intervalo + "', '" + oOrden_InternaBLL.Resolucion + "', '" + oOrden_InternaBLL.GradoClaseEscala + "', '" + oOrden_InternaBLL.AccesoriosOI + "', '" + oOrden_InternaBLL.ObservacionesOI + "', '" + oOrden_InternaBLL.Material + "', '" + oOrden_InternaBLL.NoParteOI + "', '" + oOrden_InternaBLL.NoPlano + "', '" + oOrden_InternaBLL.NoColas + "', '" + oOrden_InternaBLL.NoPiezas + "', " + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.NoIO + "); " +
            // " insert into Fotos (Id_Foto, Foto) values (" + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.fotoEquipo + ");  " +
            //  " insert into Empleado (Id_Empleado, Nombre) values (" + oOrden_InternaBLL.NoIO + ", '" + oOrden_InternaBLL.ElaboroIO + "');  " +
            // " insert into Vendedor (Id_Vendedor, Nombre) values (" + oOrden_InternaBLL.NoIO + ", '" + oOrden_InternaBLL.Vendedor + "');  " +
            // " insert into Orden_Interna (Id_OrdenInterna, No_Registros_Asignados, Fecha_ElaboracionOI, Magnitud, Fecha_Recepcion, Fecha_TerminoServicio, Id_Vendedor, Id_Empleado, Dias_Para_Entrega) values(" + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.NoRegistro_Asisgnado + ", '" + oOrden_InternaBLL.FechaElaboracionIO + "', '" + oOrden_InternaBLL.Magnitud + "', '" + oOrden_InternaBLL.Fecha_Recepcion + "', '" + oOrden_InternaBLL.Fecha_Termino_Servicio + "', " + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.DiasParaLaEntrega + "); " +
            // " insert into Detalle_Orden (Id_Detalle, Id_Equipo, Id_Cliente, Id_OrdenInterna, Fecha_Recepcion) values (" + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.NoIO + ", '" + oOrden_InternaBLL.Fecha_Recepcion + "');");
        }
        public bool AgregarFoto(Orden_InternaBLL oOrden_InternaBLL) {

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Fotos ( Id_Foto, Foto) VALUES(@ID, @Foto)");
            sqlCommand.Parameters.Add("@Foto", SqlDbType.Image).Value = oOrden_InternaBLL.fotoEquipo;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = oOrden_InternaBLL.NoIO;

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);


            //return conexionDAL.EjecutarComandoSinRetornoDatos(" insert into Fotos (Id_Foto, Foto) values (" + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.fotoEquipo + "); "  );        

        }
        public bool EliminarFoto(Orden_InternaBLL oOrden_InternaBLL)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Fotos WHERE Id_Foto=@ID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = oOrden_InternaBLL.NoIO;
            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);

        }


        public bool AgregarEquipo(Orden_InternaBLL oOrden_InternaBLL)
        {
            return conexionDAL.EjecutarComandoSinRetornoDatos("insert into Equipo (Id_Equipo, No_Ingreso, Tipo_Servicio, Nombre_Equipo, Marca, Codigo_Fabricante, Num_Serie, Identificacion, Intervalo, Resolucion, Grado_ClaseEscala, Accesorios, Observaciones, Material, No_Parte, No_Plano, No_Cotas, No_Piezas, Id_Foto, Id_Cliente) values (" + oOrden_InternaBLL.NoIOT + ", " + oOrden_InternaBLL.NoIngresoT + ", '" + oOrden_InternaBLL.TipoServicio + "', '" + oOrden_InternaBLL.Equipo + "', '" + oOrden_InternaBLL.Marca_Modelo + "', '" + oOrden_InternaBLL.CodFabricante + "', '" + oOrden_InternaBLL.Serie + "', '" + oOrden_InternaBLL.Identificador + "', '" + oOrden_InternaBLL.Intervalo + "', '" + oOrden_InternaBLL.Resolucion + "', '" + oOrden_InternaBLL.GradoClaseEscala + "', '" + oOrden_InternaBLL.AccesoriosOI + "', '" + oOrden_InternaBLL.ObservacionesOI + "', '" + oOrden_InternaBLL.Material + "', '" + oOrden_InternaBLL.NoParteOI + "', '" + oOrden_InternaBLL.NoPlano + "', '" + oOrden_InternaBLL.NoColas + "', '" + oOrden_InternaBLL.NoPiezas + "', " + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.NoIO + "); ");

        }


        public bool AgregarOrden_Interna(Orden_InternaBLL oOrden_InternaBLL)
        {
            return conexionDAL.EjecutarComandoSinRetornoDatos(" insert into Orden_Interna (Id_OrdenInterna, No_Registros_Asignados, Fecha_ElaboracionOI, Magnitud, Fecha_Recepcion, Fecha_TerminoServicio, Id_Vendedor, Id_Empleado, Dias_Para_Entrega) values(" + oOrden_InternaBLL.NoIO + ", " + oOrden_InternaBLL.NoRegistro_Asisgnado + ", '" + oOrden_InternaBLL.FechaElaboracionIO + "', '" + oOrden_InternaBLL.Magnitud + "', '" + oOrden_InternaBLL.Fecha_Recepcion + "', '" + oOrden_InternaBLL.Fecha_Termino_Servicio + "', 1, 1, " + oOrden_InternaBLL.DiasParaLaEntrega + "); " );

        }



        public bool ModificarCliente(Orden_InternaBLL oOrden_InternaBLL)
        {

            return conexionDAL.EjecutarComandoSinRetornoDatos("UPDATE Cliente SET Nombre = '"+oOrden_InternaBLL.NombreClienteE+"', Direccion = '"+oOrden_InternaBLL.DireccionClienteE+"', Atencion = '"+oOrden_InternaBLL.AtencionClienteE+"' WHERE Id_Cliente = "+oOrden_InternaBLL.NoIO+";");

        }

        public bool ModificarEquipo(Orden_InternaBLL oOrden_InternaBLL)
        {

            return conexionDAL.EjecutarComandoSinRetornoDatos("UPDATE Equipo SET No_Ingreso = "+oOrden_InternaBLL.NoIngresoT+", Tipo_Servicio = '"+oOrden_InternaBLL.TipoServicio+"', Nombre_Equipo = '"+oOrden_InternaBLL.Equipo+"', Marca = '"+oOrden_InternaBLL.Marca_Modelo+"', Codigo_Fabricante = '"+oOrden_InternaBLL.CodFabricante+"', Num_Serie = '"+oOrden_InternaBLL.Serie+"', Identificacion = '"+oOrden_InternaBLL.Identificador+"', Intervalo = '"+oOrden_InternaBLL.Intervalo+"', Resolucion = '"+oOrden_InternaBLL.Resolucion+"', Grado_ClaseEscala = '"+oOrden_InternaBLL.GradoClaseEscala+"', Accesorios = '"+oOrden_InternaBLL.AccesoriosOI+"', Observaciones = '"+oOrden_InternaBLL.ObservacionesOI+"', Material = '"+oOrden_InternaBLL.Material+"', No_Parte = '"+oOrden_InternaBLL.NoParteOI+"', No_Plano = '"+oOrden_InternaBLL.NoPlano+"', No_Cotas = '"+oOrden_InternaBLL.NoColas+"', No_Piezas = '"+oOrden_InternaBLL.NoPiezas+"', Id_Foto = "+oOrden_InternaBLL.NoIO+", Id_Cliente = "+oOrden_InternaBLL.NoIO+" WHERE Id_Equipo =  "+oOrden_InternaBLL.NoIOT+";");

        }


        public bool ModificarOrden(Orden_InternaBLL oOrden_InternaBLL)
        {

            return conexionDAL.EjecutarComandoSinRetornoDatos("UPDATE Orden_Interna SET No_Registros_Asignados = "+oOrden_InternaBLL.NoRegistro_Asisgnado+",     Fecha_ElaboracionOI = '"+oOrden_InternaBLL.FechaElaboracionIO+"',    Magnitud = '"+oOrden_InternaBLL.Magnitud+"',     Fecha_Recepcion = '"+oOrden_InternaBLL.Fecha_Recepcion+"',     Fecha_TerminoServicio = '"+oOrden_InternaBLL.Fecha_Termino_Servicio+"',     Id_Vendedor = 1,    Id_Empleado = 1,    Dias_Para_Entrega = "+oOrden_InternaBLL.DiasParaLaEntrega+" WHERE Id_OrdenInterna = "+oOrden_InternaBLL.NoIO+";");

        }

        public bool EliminarCliente(Orden_InternaBLL oOrden_InternaBLL)
        {

            return conexionDAL.EjecutarComandoSinRetornoDatos("DELETE FROM Cliente WHERE Id_Cliente = "+oOrden_InternaBLL.NoIO+";");
        }

        public bool EliminarEquipo(Orden_InternaBLL oOrden_InternaBLL)
        {

            return conexionDAL.EjecutarComandoSinRetornoDatos("DELETE FROM Equipo WHERE Id_Equipo = " + oOrden_InternaBLL.NoIOT + ";");
        }

        public bool EliminarOrden(Orden_InternaBLL oOrden_InternaBLL)
        {

            return conexionDAL.EjecutarComandoSinRetornoDatos("DELETE FROM Orden_Interna WHERE Id_OrdenInterna = " + oOrden_InternaBLL.NoIO + ";");
        }



        public DataSet MostrarCliente()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Cliente;");
            return conexionDAL.EjecutarSentencia(sentencia);
        }

        public DataSet MostrarEquipo()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Equipo;");
            return conexionDAL.EjecutarSentencia(sentencia);
        }

        public DataSet MostrarFoto()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Fotos;");
            return conexionDAL.EjecutarSentencia(sentencia);
        }

        public DataSet MostrarOrden()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Orden_Interna;");
            return conexionDAL.EjecutarSentencia(sentencia);
        }



        public DataSet Mostrarodo()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM View_ClienteEquipoOrden2;");
            return conexionDAL.EjecutarSentencia(sentencia);
        }

    }
}
