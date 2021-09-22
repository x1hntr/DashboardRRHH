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
    public class Consulta3CN
    {

        private Consulta3DAL cl = new Consulta3DAL();
        public DataTable MostrarConsulta3()
        {
            DataTable tabla = new DataTable();
            tabla = cl.mostrarDepV ();
            return tabla;
        }
        public List<EConsulta3> ListaConsulta()
        {

            Consulta3CN co = new Consulta3CN();
            List<EConsulta3> listaConsulta = new List<EConsulta3>();
            DataTable tab = co.MostrarConsulta3();
            foreach (DataRow d in tab.Rows)
            {
                EConsulta3 x = new EConsulta3(d["apellido"].ToString(), d["oficio"].ToString());
                listaConsulta.Add(x);
            }
            return listaConsulta;

        }

    }
}
