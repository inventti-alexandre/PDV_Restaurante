﻿using PDVRestaurante.BaseDatos;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVRestaurante.Pantallas.Usuarios
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
            comboBoxCedula.DataSource = EmpleadoDB.ObtenerEmpleados();
            comboBoxCedula.DisplayMember = "Cedula";
            comboBoxTipoUsuario.DataSource = TipoUsuarioDB.ObtenerTipoUsuarios();
            comboBoxTipoUsuario.DisplayMember = "Nombre";
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var empleado = (Empleado)comboBoxCedula.SelectedItem;
            var tipoUsuario = (TipoUsuario)comboBoxTipoUsuario.SelectedItem;
            var contrasena = Ayudantes.Encriptador.Encriptar(Ayudantes.Encriptador.ComoTextoSeguro(textBoxContrasena.Text));
            UsuarioDB.InsertarUsuario(textBoxNombre.Text.ToLower(), contrasena, empleado.Cedula, tipoUsuario.TipoUsuarioId);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}