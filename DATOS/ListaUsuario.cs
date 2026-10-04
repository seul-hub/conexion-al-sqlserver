
﻿using entidades;

﻿ using entidades;

using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic;
using SISTEMA;
using System;
using System.Collections.Generic;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DATOS
{
    public class ListarUsuario
    {
        private Conexion conexion = new Conexion();

        // Trae TODOS los usuarios, pero con datos "resumidos y legibles" (UsuarioListado),
        // pensado específicamente para mostrar en el DataGridView de FrmListarUsuario.
        public List<UsuarioListado> Listar()
        {
            List<UsuarioListado> lista = new List<UsuarioListado>();

            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_usuarios", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    UsuarioListado usuario = new UsuarioListado();
                    usuario.IdUsuario = Convert.ToInt32(lector["id_usuario"]);
                    usuario.UserName = lector["user_name"].ToString();
                    usuario.Nombre = lector["nombre"].ToString();
                    usuario.Apellido = lector["apellido"].ToString();
                    usuario.NombreRol = lector["nombre_rol"].ToString();

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

        // Trae UN SOLO usuario, con TODOS sus datos (no resumidos como arriba),
        // pensado para precargar FrmModificarUsuario cuando se va a editar a alguien puntual.
        public Usuario ObtenerPorId(int idUsuario)
        {
            Usuario usuario = null;

            try
            {
                SqlCommand comando = new SqlCommand("sp_buscar_usuario", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_usuario", idUsuario);

                conexion.AbrirConexion();

                SqlDataReader lector = comando.ExecuteReader();

                // if (no while): acá se espera como mucho UNA fila, porque el id_usuario es único.
                if (lector.Read())
                {
                    usuario = new Usuario();
                    usuario.IdUsuario = Convert.ToInt32(lector["id_usuario"]);
                    usuario.UserName = lector["user_name"].ToString();
                    usuario.password = lector["password"].ToString();
                    usuario.activo = Convert.ToBoolean(lector["activo"]);
                    usuario.DebeCambiarPass = Convert.ToBoolean(lector["debe_cambiar_pass"]);
                    usuario.DiasValidezPass = Convert.ToInt32(lector["dias_validez_pass"]);
                    usuario.IntentosFallidos = Convert.ToInt32(lector["intentos_fallidos"]);
                    usuario.HoraUltimoIntento = Convert.ToDateTime(lector["hora_ultimo_intento"]);
                    usuario.IdPersona = Convert.ToInt32(lector["id_persona"]);
                    usuario.IdRol = Convert.ToInt32(lector["id_rol"]);
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

            return usuario; // devuelve el usuario encontrado, o null si no existía ese ID
        }
    } 
}