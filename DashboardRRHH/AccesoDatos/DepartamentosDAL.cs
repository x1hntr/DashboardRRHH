using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AccesoDatos
{
    public class DepartamentosDAL
    {

        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarDepartamentos() {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarDepartamentos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void crearDepartamento(int depN, string dNombre, string locacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "crearDepartamento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@depN", depN);
            comando.Parameters.AddWithValue("@dNombre", dNombre);
            comando.Parameters.AddWithValue("@locacion", locacion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
         }

        public void editarDepartamento(int depN, string dNombre, string locacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarDepartamentos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@depN", depN);
            comando.Parameters.AddWithValue("@dNombre", dNombre);
            comando.Parameters.AddWithValue("@locacion", locacion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void eliminarDepartamento(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarDepartamento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@depN", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
