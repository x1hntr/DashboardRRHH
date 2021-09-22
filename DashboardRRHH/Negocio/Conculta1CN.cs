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
    public class Conculta1CN
    {
        private Consulta1DAL cl = new Consulta1DAL();
        public DataTable MostrarConsulta1()
        {
            DataTable tabla = new DataTable();
            tabla = cl.mostrarAreas();
            return tabla;
        }
        public List<EConsulta1> ListaConsulta() {

            Conculta1CN co = new Conculta1CN();
            List<EConsulta1> listaConsulta = new List<EConsulta1>();
            DataTable tab = co.MostrarConsulta1();
            foreach (DataRow d in tab.Rows) {
                EConsulta1 x = new EConsulta1(d["dnombre"].ToString(), int.Parse(d["cantidad"].ToString()));
                listaConsulta.Add(x);
            }
            return listaConsulta;
        
        }


    }
}
