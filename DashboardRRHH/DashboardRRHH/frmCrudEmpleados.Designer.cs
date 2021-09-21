
namespace DashboardRRHH
{
    partial class frmCrudEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkComision = new System.Windows.Forms.CheckBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOficio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 47);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(219, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(42, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvEmpleados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 385);
            this.panel2.TabIndex = 1;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(386, 383);
            this.dgvEmpleados.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtSalario);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.chkComision);
            this.panel3.Controls.Add(this.txtComision);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dtpFecha);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbDepartamento);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtDireccion);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmbOficio);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtApellido);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(403, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 444);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.ForeColor = System.Drawing.Color.White;
            this.txtSalario.Location = new System.Drawing.Point(17, 183);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(155, 26);
            this.txtSalario.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(145, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 31);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // chkComision
            // 
            this.chkComision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkComision.AutoSize = true;
            this.chkComision.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComision.ForeColor = System.Drawing.Color.White;
            this.chkComision.Location = new System.Drawing.Point(216, 320);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(94, 24);
            this.chkComision.TabIndex = 13;
            this.chkComision.Text = "Comisión";
            this.chkComision.UseVisualStyleBackColor = true;
            // 
            // txtComision
            // 
            this.txtComision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtComision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.txtComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComision.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComision.ForeColor = System.Drawing.Color.White;
            this.txtComision.Location = new System.Drawing.Point(216, 347);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(157, 26);
            this.txtComision.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(15, 261);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(356, 23);
            this.dtpFecha.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(214, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.cmbDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartamento.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbDepartamento.ForeColor = System.Drawing.Color.White;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(216, 182);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(157, 28);
            this.cmbDepartamento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(15, 347);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 26);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(216, 101);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(157, 26);
            this.txtDireccion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oficio";
            // 
            // cmbOficio
            // 
            this.cmbOficio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbOficio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.cmbOficio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOficio.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbOficio.ForeColor = System.Drawing.Color.White;
            this.cmbOficio.FormattingEnabled = true;
            this.cmbOficio.Location = new System.Drawing.Point(17, 99);
            this.cmbOficio.Name = "cmbOficio";
            this.cmbOficio.Size = new System.Drawing.Size(155, 28);
            this.cmbOficio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(15, 28);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(356, 26);
            this.txtApellido.TabIndex = 0;
            // 
            // frmCrudEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudEmpleados";
            this.Text = "frmCrudEmpleados";
            this.Load += new System.EventHandler(this.frmCrudEmpleados_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox chkComision;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOficio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
    }
}