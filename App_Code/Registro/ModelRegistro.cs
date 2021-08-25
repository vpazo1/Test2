using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendarios.App_Code.Registro
{
    public class ModelRegistro
    {
        public byte EnfermedadRespiratoria { get; set; }
        public byte Diabetes { get; set; }
        public byte ProblemasAuditivos { get; set; }
        public byte OtraEnfermedad { get; set; }
        public byte OtroMedicamento { get; set; }
        public byte Seguro { get; set; }
        public byte AceptaTerminos { get; set; }
        public String FechaNacimiento { get; set; }
        public int IdRegistro { get; set; }
        public int NumeroRec { get; set; }
        public int IdPais { get; set; }
        public int IdPaisContacto { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Correo { get; set; }
        public String Identificacion { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String EstadoCivil { get; set; }
        public String Talla { get; set; }
        public String Religion { get; set; }
        public String Observaciones { get; set; }
        public String NombreContacto { get; set; }
        public String CorreoContacto { get; set; }
        public String TelefonoContacto { get; set; }
        public String TipoSangre { get; set; }
        public String DetalleOtraEnfermedad { get; set; }
        public String DetalleOtroMedicamento { get; set; }
        public String NombreSeguro { get; set; }
        public String TelefonoSeguro { get; set; }
        public String CarnetSeguro { get; set; }

    }
}