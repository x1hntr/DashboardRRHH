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
using AccesoDatos;
using System.Collections;

namespace DashboardRRHH
{
    public partial class frmDepartamentos : Form
    {
        DepartamentosCN dep = new DepartamentosCN();
        private string depN = null;
        bool editar = false;

        ArrayList departamentos = new ArrayList();
        ArrayList numEmpleados =  new ArrayList();

        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            DepartamentosCN departamento = new DepartamentosCN();
            dgvDepartamentos.DataSource = departamento.mostrarDepartamentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count > 0) {
               depN = dgvDepartamentos.CurrentRow.Cells["dept_no"].Value.ToString();
                dep.eliminarDepartamento(Int16.Parse(depN));
                MessageBox.Show("Eliminado Correctamente");
                DepartamentosCN dep1 = new DepartamentosCN();
                dgvDepartamentos.DataSource = dep1.mostrarDepartamentos();
            }
            else
                MessageBox.Show("Seleccione un departamento a eliminar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false) {
                dep.crearDepartamento(int.Parse(txtDepN.Text), txtNombre.Text, txtLocacion.Text);
                txtDepN.Text = "";
                txtLocacion.Text = "";
                txtNombre.Text = "";
                DepartamentosCN dep1 = new DepartamentosCN();
                dgvDepartamentos.DataSource = dep1.mostrarDepartamentos();
            }

            if (editar == true)
            {
                dep.editarDepartamento(int.Parse(txtDepN.Text), txtNombre.Text, txtLocacion.Text);
                txtDepN.Text = "";
                txtLocacion.Text = "";
                txtNombre.Text = "";
                DepartamentosCN dep1 = new DepartamentosCN();
                dgvDepartamentos.DataSource = dep1.mostrarDepartamentos();
            }

        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count > 0)
            {
                editar = true;
                depN = dgvDepartamentos.CurrentRow.Cells["dept_no"].Value.ToString();
                txtDepN.Text = dgvDepartamentos.CurrentRow.Cells["dept_no"].Value.ToString();
                txtNombre.Text = dgvDepartamentos.CurrentRow.Cells["dnombre"].Value.ToString();
                txtLocacion.Text = dgvDepartamentos.CurrentRow.Cells["loc"].Value.ToString();
            }
            else
                MessageBox.Show("Selecciones una fila para editar");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
