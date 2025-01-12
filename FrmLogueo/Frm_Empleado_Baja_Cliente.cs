﻿using System;
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
    public partial class Frm_Empleado_Baja_Cliente : Frm_Empleado_Diseño
    {
        List<Cliente> clientesActivos;
        public Frm_Empleado_Baja_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Baja_Cliente_Load(object sender, EventArgs e)
        {
            clientesActivos = Conexion_SQL.ObtenerClientes("clientes").FindAll(cliente => cliente.Estado == true);
            OrganizarDtg(clientesActivos);
        }

        private void dtg_ListarClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_BajaID.Text = dtg_ListarClientes.CurrentRow.Cells[0].Value.ToString();
            txt_BajaNombre.Text = dtg_ListarClientes.CurrentRow.Cells[1].Value.ToString();
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = Repositorio_Clientes.Repo_Clientes.DarDeBaja(txt_BajaID.Text);
                MessageBox.Show("BAJA CONFIRMADA\n" + cliente.ToString());

                dtg_ListarClientes.DataSource = null;
                dtg_ListarClientes.AutoGenerateColumns = false;
                dtg_ListarClientes.DataSource = Repositorio_Clientes.ListaClientes;
                dtg_ListarClientes.Columns.Clear();
                clientesActivos = Conexion_SQL.ObtenerClientes("clientes").FindAll(cliente => cliente.Estado == true);
                OrganizarDtg(clientesActivos);
            }
            catch (Exception ex)
            {
                Log_Errores.EscribirLogErrores(ex);
                MessageBox.Show(ex.Message);
            }
        }
        private void OrganizarDtg(List<Cliente> clientesActivos)
        {

            dtg_ListarClientes.AutoGenerateColumns = false;


            dtg_ListarClientes.DataSource = clientesActivos;
            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdCliente",
                HeaderText = "ID",
                DisplayIndex = 0
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                DisplayIndex = 1
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DireccionBSAS",
                HeaderText = "Dirección",
                DisplayIndex = 2
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Rubro",
                HeaderText = "Rubro",
                DisplayIndex = 3
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Mail",
                HeaderText = "Mail",
                DisplayIndex = 4
            });
        }
    }
}
