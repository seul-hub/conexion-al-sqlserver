using entidades;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Collections.Generic;
using System.Data;

namespace DATOS
{
    public class ListarUsuario
    {
        private Conexion conexion = new Conexion();

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_usuarios", conexion.ObtenerConexion());

                comando.CommandType = CommandType.StoredProcedure;

                conexion.AbrirConexion();

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.IdUsuario = Convert.ToInt32(lector["id_usuario"]);
                    usuario.UserName = lector["user_name"].ToString();

                    lista.Add(usuario);
                }

                lector.Close();
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