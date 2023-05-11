﻿using FrmLogueo;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransporteRodriguez;
namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleado_Menu : Form
    {
        //List<Cliente> listaEmpleados;
        Usuario usuarioInstanciado;

        public Usuario UsuarioInstanciado { get => usuarioInstanciado; set => usuarioInstanciado = value; }

        public Frm_Empleado_Menu()
        {
            InitializeComponent();

            //  listaEmpleados = new List<Cliente>();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTACIO EL FORMULARIO SIGUIENTE
            Frm_Empleado_Alta_Cliente frmAltaCliente = new Frm_Empleado_Alta_Cliente();
            frmAltaCliente.EmpleadoInstanciado = usuarioInstanciado;
            //DialogResult confirmacion
            if (frmAltaCliente.ShowDialog() == DialogResult.OK) //cuando mostramos con ShowDialog damos foco a ese formulario
            {

            }


        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Form anterior = new Frm_Login(); // Crea una instancia del formulario anterior
            anterior.ShowDialog(); // Muestra el formulario anterior como diálogo
            //this.Close(); // Cierra el formulario actual
        }

        private void FrmMenuEmpleado_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario.Text = UsuarioInstanciado.Nombre;
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Empleados_Lista_Vehiculos frmListarVehiculos = new Frm_Empleados_Lista_Vehiculos();
            frmListarVehiculos.UsuarioInstanciado = usuarioInstanciado;
            this.Close();
            frmListarVehiculos.ShowDialog();
        }
    }
}