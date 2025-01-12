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
    public partial class Frm_Empleado_Baja_Vehiculo : Frm_Empleado_Diseño
    {
        List<Vehiculo> vehiculosActivos;
        public Frm_Empleado_Baja_Vehiculo()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Baja_Vehiculo_Load(object sender, EventArgs e)
        {
            vehiculosActivos = Conexion_SQL.ObtenerVehiculos("vehiculos").FindAll(vehiculo => vehiculo.Estado == true);
            OrganizarDataGridVehiculos(vehiculosActivos);
        }
        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = Repositorio_Vehiculos.Repo_Vehiculos.DarDeBaja(txt_BajaID.Text);
                dtg_Listar.Columns.Clear();
                vehiculosActivos = Conexion_SQL.ObtenerVehiculos("vehiculos").FindAll(vehiculo => vehiculo.Estado == true);
                OrganizarDataGridVehiculos(vehiculosActivos);
                MessageBox.Show("Vehiculo con patente " + vehiculo.Patente + " dado de baja satisfactoriamente.");
            }
            catch (Exception ex)
            {
                Log_Errores.EscribirLogErrores(ex);
                MessageBox.Show(ex.Message);
            }
        }
        private void dtg_Listar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_BajaID.Text = dtg_Listar.CurrentRow.Cells[0].Value.ToString();
            txt_BajaPatente.Text = dtg_Listar.CurrentRow.Cells[3].Value.ToString();
        }
        public void OrganizarDataGridVehiculos(List<Vehiculo> vehiculosActivos)
        {
            dtg_Listar.AutoGenerateColumns = false;
            dtg_Listar.DataSource = vehiculosActivos;

            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdVehiculo",
                HeaderText = "ID",
                DisplayIndex = 0
            });

            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MarcaVehiculo",
                HeaderText = "Marca",
                DisplayIndex = 1
            });
            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CapacidadDeCarga",
                HeaderText = "Carga Soportada",
                DisplayIndex = 2
            });
            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Patente",
                HeaderText = "Patente",
                DisplayIndex = 3
            });
            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Color",
                HeaderText = "Color",
                DisplayIndex = 4
            });
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
