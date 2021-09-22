using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class EConsulta2
    {
        private string dnombre;
      
        public EConsulta2(string dnombre)
        {
            this.dnombre = dnombre;
          
        }

        public string Dnombre { get => dnombre; set => dnombre = value; }

        public override string ToString()
        {
            return "Apellido: " + dnombre;
        }
    }
}
