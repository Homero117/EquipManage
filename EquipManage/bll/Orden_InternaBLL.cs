using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipManage.BLL
{
    internal class Orden_InternaBLL
    {
        public string Magnitud { get; set; }
        public string Fecha_Recepcion { get; set; }
        public string Fecha_Termino_Servicio { get; set; }
        public string Vendedor { get; set; }
        public string ElaboroIO { get; set; }
        public int NoIO { get; set; }
        public int NoRegistro_Asisgnado { get; set; }
        public string FechaElaboracionIO { get; set; }
        public string NombreClienteE { get; set; }
        public string DireccionClienteE { get; set; }
        public string AtencionClienteE { get; set; }
        public string NombreClienteF { get; set; }
        public string ActividadRealizar { get; set; }
        public string LugarCalibracionMedicion { get; set; }
        public string Observaciones_GeneralesOI { get; set; }
        public string NoIngresoIO { get; set; }
        public string CertificadoInforme { get; set; }
        public string TipoServicio { get; set; }
        public string Equipo { get; set; }
        public string Marca_Modelo { get; set; }
        public string CodFabricante { get; set; }
        public string Serie { get; set; }
        public string Identificador { get; set; }
        public string Intervalo { get; set; }
        public string Resolucion { get; set; }
        public string GradoClaseEscala { get; set; }
        public string AccesoriosOI { get; set; }
        public string ObservacionesOI { get; set; }
        public string Material { get; set; }
        public string NoParteOI { get; set; }
        public string NoPlano { get; set; }
        public string NoColas { get; set; }
        public string NoPiezas { get; set; }
        public int DiasParaLaEntrega { get; set; }
        public byte[] fotoEquipo { get; set; }
        public int NoIOT { get; set; }
        public int NoIngresoT { get; set; }
    }
}
