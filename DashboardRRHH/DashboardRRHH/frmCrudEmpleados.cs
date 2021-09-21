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
namespace DashboardRRHH
{
    public partial class frmCrudEmpleados : Form
    {
        public frmCrudEmpleados()
        {
            InitializeComponent();
        }

        private void frmCrudEmpleados_Load(object sender, EventArgs e)
        {
            EmpleadoCN empleado = new EmpleadoCN();
            dgvEmpleados.DataSource = empleado.mostrarEmpleados();
        }

     
    }
}
