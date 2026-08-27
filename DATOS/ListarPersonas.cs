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
            List<Persona> lista = new List<Persona>();

            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_personas", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();

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
