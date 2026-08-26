using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System.Data;

namespace DATOS
{
    public class ListarPersonas
    {
        private Conexion conexion = new Conexion();//es el encargado de permitir la conexion a la BD de sqlserver.

        public List<Persona> Listar()
        {
            List<Persona> lista = new List<Persona>();

            try
            {
                SqlCommand comando= new SqlCommand("sp_listar_personas", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();//esto lo utilizamos cuando queremos recibir datos de la BD, en este caso nos devuelve un conjunto de registros.
                                                               //El lector sirve para leer los registros que devuelve SQL Server.
                while (reader.Read())
                {
                    Persona persona = new Persona
                    {
                        idpersona = Convert.ToInt32(reader["idpersona"]),
                        nombre = reader["nombre"].ToString(),
                        apellido = reader["apellido"].ToString(),
                        imagenUrl = reader["imagenUrl"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["Fecha_nacimiento"]),
                        activo = Convert.ToBoolean(reader["activo"]),
                        legajo = Convert.ToInt32(reader["legajo"]),
                        Dni = reader["Dni"].ToString(),
                        fechaAlta = Convert.ToDateTime(reader["fecha_alta"]),
                        fechaBaja = reader["fecha_baja"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["fechaBaja"]),
                        email = reader["email"].ToString(),
                        idDomicilio = reader["id_domicilio"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["idDomicilio"])
                    };
                    lista.Add(persona);
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return lista;
        }
    }
}

