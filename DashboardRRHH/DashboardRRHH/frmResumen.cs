using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace DashboardRRHH
{
    public partial class frmResumen : Form
    {
        private List<EConsulta1> listaConsulta1 = new List<EConsulta1>();
        Conculta1CN cl = new Conculta1CN();

        private List<EConsulta2> listaConsulta2 = new List<EConsulta2>();
        Consulta2CN cl2 = new Consulta2CN();

        private List<EConsulta3> listaConsulta3 = new List<EConsulta3>();
        Consulta3CN cl3 = new Consulta3CN();

        private List<EConsulta4> listaConsulta4 = new List<EConsulta4>();
        Consulta4CN cl4 = new Consulta4CN();

        public frmResumen()
        {
            InitializeComponent();
        }

        private void frmResumen_Load(object sender, EventArgs e)
        {
            llenarConsulta1();
            llenarConsulta2();
            llenarConsulta3();
            llenarConsulta4();

        }

        private void llenarConsulta1() {
            listaConsulta1 = cl.ListaConsulta();
            foreach (EConsulta1 cl in listaConsulta1) {
                lbConsulta1.Items.Add(cl);
            }
        }

        private void llenarConsulta2()
        {
            listaConsulta2 = cl2.ListaConsulta();
            foreach (EConsulta2 cl2 in listaConsulta2)
            {
                lbSinComision.Items.Add(cl2);
            }
        }

        private void llenarConsulta3()
        {
            listaConsulta3 = cl3.ListaConsulta();
            foreach (EConsulta3 cl3 in listaConsulta3)
            {
                lbDep20.Items.Add(cl3);
            }
        }
        private void llenarConsulta4()
        {
            listaConsulta4 = cl4.ListaConsulta();
            foreach (EConsulta4 cl4 in listaConsulta4)
            {
                lbCom.Items.Add(cl4);
            }
        }

    }
   

}
