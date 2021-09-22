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
    public class Consulta2CN
    {

        private Consulta2DAL cl = new Consulta2DAL();
        public DataTable MostrarConsulta1()
        {
            DataTable tabla = new DataTable();
            tabla = cl.mostrarSinComision();
            return tabla;
        }
        public List<EConsulta2> ListaConsulta()
        {

            Consulta2CN co = new Consulta2CN();
            List<EConsulta2> listaConsulta = new List<EConsulta2>();
            DataTable tab = co.MostrarConsulta1();
            foreach (DataRow d in tab.Rows)
            {
                EConsulta2 x = new EConsulta2(d["apellido"].ToString());
                listaConsulta.Add(x);
            }
            return listaConsulta;

        }

    }
}
