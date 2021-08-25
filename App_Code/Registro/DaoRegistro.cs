using Legendarios.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendarios.App_Code.Registro
{
    public class DaoRegistro
    {

        ClsErrorHandler log = new ClsErrorHandler();
        ClsConexion objCon = new ClsConexion();

        string strsql = "";


        public string Insertar(ModelRegistro operaciones)
        {
            strsql = "insert into  [Registro]  ( EnfermedadRespiratoria,	Diabetes,	ProblemasAuditivos,	OtraEnfermedad,	OtroMedicamento,	Seguro,	AceptaTerminos,	FechaNacimiento,		NumeroRec,	IdPais,	IdPaisContacto,	Nombre,	Apellido,	Correo,	Identificacion,	Direccion,	Telefono,	EstadoCivil,	Talla,	Religion,	Observaciones,	NombreContacto,	CorreoContacto,	TelefonoContacto,	TipoSangre,	DetalleOtraEnfermedad,	DetalleOtroMedicamento,	NombreSeguro,	TelefonoSeguro,	CarnetSeguro)" +
                " values (" +
                "" + operaciones.EnfermedadRespiratoria + "," +
"" + operaciones.Diabetes + "," +
"" + operaciones.ProblemasAuditivos + "," +
"" + operaciones.OtraEnfermedad + "," +
"" + operaciones.OtroMedicamento + "," +
"" + operaciones.Seguro + "," +
"" + operaciones.AceptaTerminos + "," +
"'" + operaciones.FechaNacimiento + "'," +
"" + operaciones.NumeroRec + "," +
"" + operaciones.IdPais + "," +
"" + operaciones.IdPaisContacto + "," +
"'" + operaciones.Nombre + "'," +
"'" + operaciones.Apellido + "'," +
"'" + operaciones.Correo + "'," +
"'" + operaciones.Identificacion + "'," +
"'" + operaciones.Direccion + "'," +
"'" + operaciones.Telefono + "'," +
"'" + operaciones.EstadoCivil + "'," +
"'" + operaciones.Talla + "'," +
"'" + operaciones.Religion + "'," +
"'" + operaciones.Observaciones + "'," +
"'" + operaciones.NombreContacto + "'," +
"'" + operaciones.CorreoContacto + "'," +
"'" + operaciones.TelefonoContacto + "'," +
"'" + operaciones.TipoSangre + "'," +
"'" + operaciones.DetalleOtraEnfermedad + "'," +
"'" + operaciones.DetalleOtroMedicamento + "'," +
"'" + operaciones.NombreSeguro + "'," +
"'" + operaciones.TelefonoSeguro + "'," +
"'" + operaciones.CarnetSeguro + "'" +


                ")";
            log.LogError(strsql, "query");

            return ExecuteSqlT(strsql);
            //Completado
        }


        //Estructura de un metodo para ejecutar una accion INSERT, UPDATE, DELETE en nuestra BD
        public string ExecuteSqlT(string strSql)
        {
            try
            {
                return objCon.EjecutaSQL(strSql);
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return "Error";
            }
        }

    }
}