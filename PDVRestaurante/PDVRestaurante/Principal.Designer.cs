﻿namespace PDVRestaurante
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelCrearUsuario = new System.Windows.Forms.Panel();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.comboBoxCedula = new System.Windows.Forms.ComboBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.panelConsultaEmpleados = new System.Windows.Forms.Panel();
            this.comboBoxConsultarEmpleado = new System.Windows.Forms.ComboBox();
            this.labelConsultaEmpleados = new System.Windows.Forms.Label();
            this.buttonReiniciarConsultaEmpleados = new System.Windows.Forms.Button();
            this.buttonConsultarEmpleados = new System.Windows.Forms.Button();
            this.dataGridConsultaEmpleados = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.panelCrearUsuario.SuspendLayout();
            this.panelConsultaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripPrincipal";
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEmpleadoToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.consultarToolStripMenuItem.Text = "Empleado";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // consultarEmpleadoToolStripMenuItem
            // 
            this.consultarEmpleadoToolStripMenuItem.Name = "consultarEmpleadoToolStripMenuItem";
            this.consultarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultarEmpleadoToolStripMenuItem.Text = "Consultar Empleado";
            this.consultarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpleadoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(PDVRestaurante.Objetos.Empleado);
            this.empleadoBindingSource.CurrentChanged += new System.EventHandler(this.empleadoBindingSource_CurrentChanged);
            // 
            // panelCrearUsuario
            // 
            this.panelCrearUsuario.Controls.Add(this.groupBox1);
            this.panelCrearUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrearUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelCrearUsuario.Name = "panelCrearUsuario";
            this.panelCrearUsuario.Size = new System.Drawing.Size(1245, 678);
            this.panelCrearUsuario.TabIndex = 2;
            this.panelCrearUsuario.Visible = false;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(278, 243);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(177, 52);
            this.buttonCrear.TabIndex = 18;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre de Usuario";
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(390, 181);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(252, 24);
            this.comboBoxTipoUsuario.TabIndex = 13;
            // 
            // comboBoxCedula
            // 
            this.comboBoxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCedula.FormattingEnabled = true;
            this.comboBoxCedula.Location = new System.Drawing.Point(390, 128);
            this.comboBoxCedula.Name = "comboBoxCedula";
            this.comboBoxCedula.Size = new System.Drawing.Size(253, 24);
            this.comboBoxCedula.TabIndex = 12;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.Location = new System.Drawing.Point(390, 81);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(253, 22);
            this.textBoxContrasena.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(390, 35);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(253, 22);
            this.textBoxNombre.TabIndex = 10;
            // 
            // panelConsultaEmpleados
            // 
            this.panelConsultaEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelConsultaEmpleados.Controls.Add(this.comboBoxConsultarEmpleado);
            this.panelConsultaEmpleados.Controls.Add(this.labelConsultaEmpleados);
            this.panelConsultaEmpleados.Controls.Add(this.buttonReiniciarConsultaEmpleados);
            this.panelConsultaEmpleados.Controls.Add(this.buttonConsultarEmpleados);
            this.panelConsultaEmpleados.Controls.Add(this.dataGridConsultaEmpleados);
            this.panelConsultaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultaEmpleados.Location = new System.Drawing.Point(0, 0);
            this.panelConsultaEmpleados.Name = "panelConsultaEmpleados";
            this.panelConsultaEmpleados.Size = new System.Drawing.Size(1245, 678);
            this.panelConsultaEmpleados.TabIndex = 4;
            this.panelConsultaEmpleados.Visible = false;
            this.panelConsultaEmpleados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultaEmpleados_Paint);
            // 
            // comboBoxConsultarEmpleado
            // 
            this.comboBoxConsultarEmpleado.FormattingEnabled = true;
            this.comboBoxConsultarEmpleado.Location = new System.Drawing.Point(306, 55);
            this.comboBoxConsultarEmpleado.Name = "comboBoxConsultarEmpleado";
            this.comboBoxConsultarEmpleado.Size = new System.Drawing.Size(261, 21);
            this.comboBoxConsultarEmpleado.TabIndex = 4;
            // 
            // labelConsultaEmpleados
            // 
            this.labelConsultaEmpleados.AutoSize = true;
            this.labelConsultaEmpleados.Location = new System.Drawing.Point(90, 58);
            this.labelConsultaEmpleados.Name = "labelConsultaEmpleados";
            this.labelConsultaEmpleados.Size = new System.Drawing.Size(210, 13);
            this.labelConsultaEmpleados.TabIndex = 3;
            this.labelConsultaEmpleados.Text = "Ingrese la cédula del empleado por buscar:";
            // 
            // buttonReiniciarConsultaEmpleados
            // 
            this.buttonReiniciarConsultaEmpleados.Location = new System.Drawing.Point(954, 39);
            this.buttonReiniciarConsultaEmpleados.Name = "buttonReiniciarConsultaEmpleados";
            this.buttonReiniciarConsultaEmpleados.Size = new System.Drawing.Size(228, 51);
            this.buttonReiniciarConsultaEmpleados.TabIndex = 2;
            this.buttonReiniciarConsultaEmpleados.Text = "Reiniciar";
            this.buttonReiniciarConsultaEmpleados.UseVisualStyleBackColor = true;
            this.buttonReiniciarConsultaEmpleados.Click += new System.EventHandler(this.buttonReiniciarConsultaEmpleados_Click);
            // 
            // buttonConsultarEmpleados
            // 
            this.buttonConsultarEmpleados.Location = new System.Drawing.Point(671, 39);
            this.buttonConsultarEmpleados.Name = "buttonConsultarEmpleados";
            this.buttonConsultarEmpleados.Size = new System.Drawing.Size(228, 51);
            this.buttonConsultarEmpleados.TabIndex = 1;
            this.buttonConsultarEmpleados.Text = "Consultar";
            this.buttonConsultarEmpleados.UseVisualStyleBackColor = true;
            this.buttonConsultarEmpleados.Click += new System.EventHandler(this.buttonConsultarEmpleados_Click);
            // 
            // dataGridConsultaEmpleados
            // 
            this.dataGridConsultaEmpleados.AllowUserToAddRows = false;
            this.dataGridConsultaEmpleados.AllowUserToDeleteRows = false;
            this.dataGridConsultaEmpleados.AllowUserToResizeColumns = false;
            this.dataGridConsultaEmpleados.AllowUserToResizeRows = false;
            this.dataGridConsultaEmpleados.AutoGenerateColumns = false;
            this.dataGridConsultaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombre1DataGridViewTextBoxColumn,
            this.nombre2DataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn});
            this.dataGridConsultaEmpleados.DataSource = this.empleadoBindingSource;
            this.dataGridConsultaEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridConsultaEmpleados.Location = new System.Drawing.Point(0, 138);
            this.dataGridConsultaEmpleados.Name = "dataGridConsultaEmpleados";
            this.dataGridConsultaEmpleados.ReadOnly = true;
            this.dataGridConsultaEmpleados.Size = new System.Drawing.Size(1245, 540);
            this.dataGridConsultaEmpleados.TabIndex = 0;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre1DataGridViewTextBoxColumn
            // 
            this.nombre1DataGridViewTextBoxColumn.DataPropertyName = "Nombre1";
            this.nombre1DataGridViewTextBoxColumn.HeaderText = "Nombre1";
            this.nombre1DataGridViewTextBoxColumn.Name = "nombre1DataGridViewTextBoxColumn";
            this.nombre1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre2DataGridViewTextBoxColumn
            // 
            this.nombre2DataGridViewTextBoxColumn.DataPropertyName = "Nombre2";
            this.nombre2DataGridViewTextBoxColumn.HeaderText = "Nombre2";
            this.nombre2DataGridViewTextBoxColumn.Name = "nombre2DataGridViewTextBoxColumn";
            this.nombre2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            this.apellido1DataGridViewTextBoxColumn.ReadOnly = true;
            this.apellido1DataGridViewTextBoxColumn.Width = 101;
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            this.apellido2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoCivilDataGridViewTextBoxColumn
            // 
            this.estadoCivilDataGridViewTextBoxColumn.DataPropertyName = "EstadoCivil";
            this.estadoCivilDataGridViewTextBoxColumn.HeaderText = "EstadoCivil";
            this.estadoCivilDataGridViewTextBoxColumn.Name = "estadoCivilDataGridViewTextBoxColumn";
            this.estadoCivilDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoCivilDataGridViewTextBoxColumn.Width = 101;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            this.idSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCrear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxTipoUsuario);
            this.groupBox1.Controls.Add(this.comboBoxCedula);
            this.groupBox1.Controls.Add(this.textBoxContrasena);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Location = new System.Drawing.Point(232, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 332);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Usuarios";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 678);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelCrearUsuario);
            this.Controls.Add(this.panelConsultaEmpleados);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.panelCrearUsuario.ResumeLayout(false);
            this.panelConsultaEmpleados.ResumeLayout(false);
            this.panelConsultaEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.Panel panelCrearUsuario;
        private System.Windows.Forms.Panel panelConsultaEmpleados;
        private System.Windows.Forms.DataGridView dataGridConsultaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxConsultarEmpleado;
        private System.Windows.Forms.Label labelConsultaEmpleados;
        private System.Windows.Forms.Button buttonReiniciarConsultaEmpleados;
        private System.Windows.Forms.Button buttonConsultarEmpleados;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.ComboBox comboBoxCedula;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}