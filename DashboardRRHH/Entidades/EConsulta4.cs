using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class EConsulta4
    {
       private int emp_no;
       private string apellido;
       private int dir;
       private int salario;

        public EConsulta4(int emp_no, string apellido, int dir, int salario)
        {
            this.emp_no = emp_no;
            this.apellido = apellido;
            this.dir = dir;
            this.salario = salario;
        }

        public int Emp_no { get => emp_no; set => emp_no = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dir { get => dir; set => dir = value; }
        public int Salario { get => salario; set => salario = value; }

        public override string ToString()
        {
            return "N. Empleado: " + emp_no + " " + "Apellido: " + apellido + " " + "Direc: "+dir + " " + "Salario: "+ salario;
        }

    }
}
