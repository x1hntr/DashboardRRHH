using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class EConsulta3
    {
        private string dnombre;
        private string oficio;

        public EConsulta3(string dnombre, string oficio)
        {
            this.dnombre = dnombre;
            this.oficio = oficio;
        }

        public string Dnombre { get => dnombre; set => dnombre = value; }
        public string Oficio { get => oficio; set => oficio = value; }

        public override string ToString()
        {
            return "Apellido: " + dnombre + "    " + "Oficio: " + oficio;
        }
    }
}
