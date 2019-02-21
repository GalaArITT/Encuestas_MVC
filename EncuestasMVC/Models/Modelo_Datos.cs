using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EncuestasMVC.Models
{
    public class ENC_CATALAGOS
    {
        public decimal IDCATALOGO { get; set; }
        public decimal IDTIPOCAT { get; set; }
        public string DATOSDELCATALOGO { get; set; }
    }

    public class ENC_EMPLEADOS
    {
        public decimal IDEMPLEADO { get; set; }
        public Nullable<decimal> IDUSUARIO { get; set; }
        public string NOMBREEMPLEADO { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONO { get; set; }
    }
    public partial class ENC_ENCUESTA
    {

        public decimal IDENCUESTA { get; set; }
        public decimal IDPREGUNTA { get; set; }
        public string CLAVEENCUESTA { get; set; }
        public System.DateTime FECHACREACION { get; set; }
        public string ESTATUS { get; set; }

    }
    public class ENC_ENCUESTAS_APLICADAS
    {
        public decimal IDENCUESTASAP { get; set; }
        public decimal IDUSUARIO { get; set; }
        public decimal IDENCUESTA { get; set; }
        public string CLAVEENCUESTA { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime FECHACREACION { get; set; }

    }
    public class ENC_PREGUNTAS
    {
        public decimal IDPREGUNTA { get; set; }
        public string PREGUNTA { get; set; }
    }
    public class ENC_RESPUESTABOOLEAN
    {
        public decimal IDRESPUESTABOOLEAN { get; set; }
        public string RESPUESTA { get; set; }
    }
    public partial class ENC_RESPUESTACATALOGO
    {
        public decimal IDRESPUESTACATALOGO { get; set; }
        public decimal IDTIPOCAT { get; set; }
        public string RESPUESTANEGATIVA { get; set; }
    }

    public partial class ENC_RESPUESTANUMERO
    {
        public decimal IDRESPUESTANUMERO { get; set; }
        public decimal RESPUESTANUMERICO { get; set; }
    }

    public partial class ENC_RESPUESTATEXTO
    {
        public decimal IDRESPUESTATEXTO { get; set; }
        public string RESPUESTA { get; set; }
    }

    public partial class ENC_ROLES
    {
        public decimal IDROLES { get; set; }
        public string TIPOROL { get; set; }
    }
    public partial class ENC_TIPOCATALOGO
    {
        public decimal IDTIPOCAT { get; set; }
        public string TIPOCATALOGO { get; set; }
    }

    public class ENC_USUARIOS
    {
        public decimal IDUSUARIO { get; set; }
        public decimal IDROLES { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public string PASSWORD { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime FECHACREACION { get; set; }
        public string ESTATUS { get; set; }
    }

    public class ENC_USUARIOS_EMPLEADOS
    {
        public ENC_USUARIOS eNC_USUARIOS { get; set; }
        public ENC_EMPLEADOS eNC_EMPLEADOS { get; set; }
    }
}