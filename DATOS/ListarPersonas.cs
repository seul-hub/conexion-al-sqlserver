using System;
using System.Collections.Generic;
using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System.Data;

namespace DATOS
{
    public class ListarPersonas
    {
        private Conexion conexion = new Conexion();

        public List<Persona> Listar()
        {
            List<Persona> lista = new List<Persona>(); // acá se van a ir juntando todas las personas leídas

            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_personas", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();

                // while (en vez de if, como en Login): acá SÍ se espera más de una fila,
                // porque el SP puede devolver muchas personas, no una sola.
                while (reader.Read())
                {
                    Persona persona = new Persona
                    {
                        idpersona = Convert.ToInt32(reader["id_persona"]),
                        nombre = reader["nombre"].ToString(),
                        apellido = reader["apellido"].ToString(),
                        legajo = Convert.ToInt32(reader["legajo"]),
                        Dni = reader["dni"].ToString(),
                        email = reader["email"].ToString(),
                        activo = Convert.ToBoolean(reader["activo"])
                    };
                    lista.Add(persona); // agrega esta persona a la lista antes de pasar a la siguiente fila
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

            return lista; // devuelve la lista completa, con todas las personas que se hayan leído
        }
    }
}