using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class EConsulta1
    {
        private string dnombre;
        private int cantidad;

        public EConsulta1(string dnombre, int cantidad) {
            this.dnombre = dnombre;
            this.cantidad = cantidad;

        
        }

        public string Dnombre { get => dnombre; set => dnombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public override string ToString()
        {
            return "Area: " + dnombre + "    N. Empleados: " + cantidad;
        }
    }
}
