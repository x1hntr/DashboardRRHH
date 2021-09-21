using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;

namespace Negocio
{
    public class DepartamentosCN
    {
        private DepartamentosDAL departamento = new DepartamentosDAL();

        public DataTable mostrarDepartamentos() {
            DataTable tabla = new DataTable();
            tabla = departamento.mostrarDepartamentos();
            return tabla;
        }

        public void eliminarDepartamento(int depN) {
            departamento.eliminarDepartamento(depN);
        }
        public void crearDepartamento(int depN, string dNombre, string locacion)
        {
            departamento.crearDepartamento(depN, dNombre, locacion);
        }
        public void editarDepartamento(int depN, string dNombre, string locacion)
        {
            departamento.editarDepartamento(depN, dNombre, locacion);
        }
    }
}
