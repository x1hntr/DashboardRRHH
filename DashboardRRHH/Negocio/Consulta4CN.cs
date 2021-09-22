using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using Entidades;

namespace Negocio
{
  public  class Consulta4CN
    {

        private Consulta4DAL cl = new Consulta4DAL();
        public DataTable MostrarConsulta()
        {
            DataTable tabla = new DataTable();
            tabla = cl.mostrarEmpleado();
            return tabla;
        }
        public List<EConsulta4> ListaConsulta()
        {

            Consulta4CN co = new Consulta4CN();
            List<EConsulta4> listaConsulta = new List<EConsulta4>();
            DataTable tab = co.MostrarConsulta();
            foreach (DataRow d in tab.Rows)
            {
                EConsulta4 x = new EConsulta4(int.Parse(d["emp_no"].ToString()), d["apellido"].ToString(), int.Parse(d["dir"].ToString()), int.Parse(d["salario"].ToString()));
                listaConsulta.Add(x);
            }
            return listaConsulta;

        }


    }
}
