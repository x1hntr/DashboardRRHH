using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AccesoDatos
{
    public class EmpleadoDAL
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarEmpleados()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void crearEmpleado(int empN, string apellido, string oficio, int dir, DateTime fecha, int salario, int comision, int depN)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "crearEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@empN", empN);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@oficio", oficio);
            comando.Parameters.AddWithValue("@dir", dir);
            comando.Parameters.AddWithValue("@fecha_alt", fecha);
            comando.Parameters.AddWithValue("@salario", salario);
            comando.Parameters.AddWithValue("@comision", comision);
            comando.Parameters.AddWithValue("@dept_no", depN);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void editarEmpleado(int empN, string apellido, string oficio, int dir, DateTime fecha, int salario, int comision, int depN)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@empN", empN);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@oficio", oficio);
            comando.Parameters.AddWithValue("@dir", dir);
            comando.Parameters.AddWithValue("@fecha_alt", fecha);
            comando.Parameters.AddWithValue("@salario", salario);
            comando.Parameters.AddWithValue("@comision", comision);
            comando.Parameters.AddWithValue("@dept_no", depN);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void eliminarEmpleado(int empN)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@empN", empN);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }

    


}
