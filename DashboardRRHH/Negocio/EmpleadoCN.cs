using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Negocio
{
    public class EmpleadoCN
    {
        private EmpleadoDAL empleado = new EmpleadoDAL();
        public DataTable mostrarEmpleados() {
            DataTable tabla = new DataTable();
            tabla = empleado.mostrarEmpleados();
            return tabla;
        }
        public void eliminarEmpleado(int depN)
        {
            empleado.eliminarEmpleado(depN);
        }
        public void crearEmpleado(int empN, string apellido, string oficio, int dir, DateTime fecha, int salario, int comision, int depN)
        {
            empleado.crearEmpleado(depN, apellido, oficio, dir, fecha, salario, comision, depN);
        }
        public void editarEmpleado(int empN, string apellido, string oficio, int dir, DateTime fecha, int salario, int comision, int depN)
        {
            empleado.editarEmpleado(empN, apellido, oficio, dir, fecha, salario, comision, depN);
        }


    }
}
