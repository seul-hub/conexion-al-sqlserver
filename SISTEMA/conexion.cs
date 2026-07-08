using System.Data;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient;
namespace SISTEMA

{
    public class Conexion
    {
        //  private SqlConnection conexion; representa la conexion a la BD de datos
        //private SqlCommand comando;sirve para usar los ejecutables SELECT,INSERT,UPDATE,DELETE,STORED PROCEDURE
        //private SqlDataReader lector;Sirve para leer los resultados de un SELECT.
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        private string cadenaConexion =
            "Server=DESKTOP-7MSL8IO;Database=SISTEMA_GESTION_USUARIO1;Trusted_Connection=True;";
        public Conexion() {
            conexion = new SqlConnection(cadenaConexion);
          }
         public void AbrirConexion()
        {
            if(conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
        }
        public void CerrarConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }
        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
