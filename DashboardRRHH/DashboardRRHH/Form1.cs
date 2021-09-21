using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardRRHH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formHijo) {
            if (this.panelContenedor.Controls.Count > 0) {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                    Form fh = formHijo as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.panelContenedor.Controls.Add(fh);
                    this.panelContenedor.Tag = fh;
                    fh.Show();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            abrirFormularioHijo(new frmResumen());
            lbLugar.Text = "Resumen";
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmResumen());
            lbLugar.Text = "Resumen";
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmCrudEmpleados());
            lbLugar.Text = "Empleados";
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("h:mm:ss");
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmDepartamentos());
            lbLugar.Text = "Departamentos";
        }
    }
}
