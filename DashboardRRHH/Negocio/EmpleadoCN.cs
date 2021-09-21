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



    }
}
