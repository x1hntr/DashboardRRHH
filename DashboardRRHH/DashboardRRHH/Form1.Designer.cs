
namespace DashboardRRHH
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLugar = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnDepartamentos);
            this.panel1.Controls.Add(this.btnResumen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 533);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbLugar);
            this.panel2.Controls.Add(this.lbFecha);
            this.panel2.Controls.Add(this.lbHora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(216, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 100);
            this.panel2.TabIndex = 1;
            // 
            // lbLugar
            // 
            this.lbLugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbLugar.AutoSize = true;
            this.lbLugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lbLugar.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lbLugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.lbLugar.Location = new System.Drawing.Point(410, 25);
            this.lbLugar.Name = "lbLugar";
            this.lbLugar.Size = new System.Drawing.Size(112, 39);
            this.lbLugar.TabIndex = 2;
            this.lbLugar.Text = "label2";
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lbFecha.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(15, 50);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(86, 30);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "label3";
            // 
            // lbHora
            // 
            this.lbHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.lbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.lbHora.Location = new System.Drawing.Point(15, 9);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(116, 40);
            this.lbHora.TabIndex = 0;
            this.lbHora.Text = "label2";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(216, 100);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(710, 433);
            this.panelContenedor.TabIndex = 2;
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = global::DashboardRRHH.Properties.Resources.trabajo_en_equipo;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(6, 190);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(204, 39);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::DashboardRRHH.Properties.Resources.flecha_de_regreso;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 482);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(195, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepartamentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnDepartamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.btnDepartamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamentos.ForeColor = System.Drawing.Color.White;
            this.btnDepartamentos.Image = global::DashboardRRHH.Properties.Resources.departamento;
            this.btnDepartamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamentos.Location = new System.Drawing.Point(6, 145);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(204, 39);
            this.btnDepartamentos.TabIndex = 3;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResumen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnResumen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.btnResumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnResumen.ForeColor = System.Drawing.Color.White;
            this.btnResumen.Image = global::DashboardRRHH.Properties.Resources.repetir;
            this.btnResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumen.Location = new System.Drawing.Point(3, 100);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(204, 39);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Text = "Resumen";
            this.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Label lbLugar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label label1;
    }
}

