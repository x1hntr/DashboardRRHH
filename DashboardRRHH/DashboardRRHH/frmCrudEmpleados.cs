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
        EmpleadoCN empleado = new EmpleadoCN();
        private string empN= null;
        bool editar = false;
        int comision = 0;
        public frmCrudEmpleados()
        {
            InitializeComponent();
        }

        private void frmCrudEmpleados_Load(object sender, EventArgs e)
        {
          
            dgvEmpleados.DataSource = empleado.mostrarEmpleados();
            chkComision.Checked = false;
            txtComision.Enabled = false;
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                empN = dgvEmpleados.CurrentRow.Cells["emp_no"].Value.ToString();
                empleado.eliminarEmpleado(Int16.Parse(empN));
                MessageBox.Show("Eliminado Correctamente");
                EmpleadoCN emp1 = new EmpleadoCN();
                dgvEmpleados.DataSource = emp1.mostrarEmpleados();
            }
            else
                MessageBox.Show("Seleccione un departamento a eliminar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (editar == false)
            {
                
                empleado.crearEmpleado(int.Parse(txtEmpN.Text), txtApellido.Text,
                    txtOficio.Text, int.Parse(txtDireccion.Text), Convert.ToDateTime(dtpFecha.Value.ToString()), 
                    int.Parse(txtSalario.Text), comision, int.Parse(txtDepartamento.Text));
                txtApellido.Text = "";
                txtComision.Text = "";
                txtDepartamento.Text = "";
                txtDireccion.Text = "";
                txtEmpN.Text = "";
                txtOficio.Text = "";
                txtSalario.Text = "";
                EmpleadoCN emp1 = new EmpleadoCN();
                dgvEmpleados.DataSource = emp1.mostrarEmpleados();
            }

            if (editar == true)
            {
                empleado.editarEmpleado(int.Parse(empN), txtApellido.Text,
                     txtOficio.Text, int.Parse(txtDireccion.Text), Convert.ToDateTime(dtpFecha.Value.ToString()),
                     int.Parse(txtSalario.Text), comision, int.Parse(txtDepartamento.Text));
                txtApellido.Text = "";
                txtComision.Text = "";
                txtDepartamento.Text = "";
                txtDireccion.Text = "";
                txtEmpN.Text = "";
                txtOficio.Text = "";
                txtSalario.Text = "";
                EmpleadoCN emp1 = new EmpleadoCN();
                dgvEmpleados.DataSource = emp1.mostrarEmpleados();
            }

            MessageBox.Show("Guardado con Exito");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                editar = true;

                empN= dgvEmpleados.CurrentRow.Cells["emp_no"].Value.ToString();
                txtApellido.Text = dgvEmpleados.CurrentRow.Cells["apellido"].Value.ToString();    
                txtDireccion.Text = dgvEmpleados.CurrentRow.Cells["dir"].Value.ToString();
                txtSalario.Text = dgvEmpleados.CurrentRow.Cells["salario"].Value.ToString();
                txtOficio.Text = dgvEmpleados.CurrentRow.Cells["oficio"].Value.ToString();
                txtDepartamento.Text = dgvEmpleados.CurrentRow.Cells["dept_no"].Value.ToString();
                txtSalario.Text = dgvEmpleados.CurrentRow.Cells["salario"].Value.ToString();
                if (dgvEmpleados.CurrentRow.Cells["comision"].Value.ToString() == "") {
                    comision = 0;
                }
                if (dgvEmpleados.CurrentRow.Cells["comision"].Value.ToString() != "")
                {
                    txtComision.Text = dgvEmpleados.CurrentRow.Cells["comision"].Value.ToString();
                    comision = int.Parse(txtComision.Text);
                }
                txtEmpN.Text = empN;
                txtEmpN.Enabled = false;

            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void chkComision_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComision.Checked == false) {
                txtComision.Enabled = false;
                comision = 0;
                txtComision.Text = "0";
            }
            if (chkComision.Checked == true)
            {
                txtComision.Enabled = true;
                comision = int.Parse(txtComision.Text);
            }
        }
    }
}
