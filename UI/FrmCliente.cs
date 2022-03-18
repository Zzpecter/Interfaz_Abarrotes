﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmCliente : Form
    {
        private DataTable dtDatosCliente;
        private String formState = "init";
        private DataLayer.Models.ViCliente clienteSeleccionado;
        private bool loading;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            await DataLayer.Tasks.Authentication.BuildAuthHeaders();
            List<DataLayer.Models.ViCliente> clientes = await DataLayer.Tasks.Cliente.listar();
            CreateDataSource(clientes);
            dgvCliente.Rows[0].Selected = true;
        }
        private void CreateDataSource(List<DataLayer.Models.ViCliente> clientes)
        {
            dtDatosCliente = new DataTable();
            dtDatosCliente.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(clientes[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatosCliente.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < clientes.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(clientes[i]);
                DataRow _tempRow = dtDatosCliente.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatosCliente.Rows.Add(_tempRow);
            }
            loading = true;
            dgvCliente.DataSource = dtDatosCliente;
            dgvCliente.Refresh();
            dgvCliente.ClearSelection();
            dgvCliente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCliente.Columns[0].HeaderText = "ID";
            dgvCliente.Columns[1].HeaderText = "Nombre/Razon Social";
            dgvCliente.Columns[2].HeaderText = "Nit/Ci";
            loading = false;
        }
        private async void RefreshData()
        {
            List<DataLayer.Models.ViCliente> clientes = await DataLayer.Tasks.Cliente.listar();
            CreateDataSource(clientes);
        }

        private void bAgregar_Click_1(object sender, EventArgs e)
        {
            formState = "agregar";
            ChangeState();
        }
        
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbNombreRazonSocial.Enabled = false;
                    tbNitCi.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvCliente.ReadOnly = false;
                    break;
                case "agregar":
                    tbNombreRazonSocial.Enabled = true;
                    tbNombreRazonSocial.Text = String.Empty;
                    tbNitCi.Enabled = true;
                    tbNitCi.Text = String.Empty;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvCliente.ClearSelection();
                    dgvCliente.ReadOnly = true;
                    break;
                case "actualizar":
                    tbNombreRazonSocial.Enabled = true;
                    tbNitCi.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvCliente.ReadOnly = true;
                    break;

            }
        }

        private void bActualizar_Click_1(object sender, EventArgs e)
        {
            formState = "actualizar";
            ChangeState();
        }

        private async void bElimiar_Click_1(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count == 1)
            {
                int statusCode = await DataLayer.Tasks.Cliente.eliminar(clienteSeleccionado.id_entidad);
                if (statusCode == 200)
                    RefreshData();
                formState = "init";
                ChangeState();
            }
        }

        private async void bGuardar_Click_1(object sender, EventArgs e)
        {
            switch (formState)
            {
                case "agregar":
                    if (tbNombreRazonSocial.Text != String.Empty && tbNitCi.Text != String.Empty)
                    {
                        DataLayer.Models.Cliente cliente = new DataLayer.Models.Cliente() { razon_social = tbNombreRazonSocial.Text, nit_ci = tbNitCi.Text, usuario_registro = "dev" };
                        int statusCode = await DataLayer.Tasks.Cliente.insertar(cliente);

                        if (statusCode == 201)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese nombre del cliente.", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (tbNombreRazonSocial.Text != String.Empty && tbNitCi.Text != String.Empty)
                    {
                        DataLayer.Models.Cliente _cliente = new DataLayer.Models.Cliente();

                        _cliente.razon_social = tbNombreRazonSocial.Text;
                        _cliente.nit_ci = tbNitCi.Text;
                        _cliente.usuario_registro = "dev"; //esto vamos a sacar de los globales, donde registraremos el usuario activo
                        int statusCode = await DataLayer.Tasks.Cliente.actualizar(_cliente, clienteSeleccionado.id_entidad);

                        if (statusCode == 200)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese el nombre del cliente.", "Error!", MessageBoxButtons.OK);
                    break;

            }
        }


        private async void dgvCliente_SelectionChanged_1(object sender, EventArgs e)
        {
            if (loading == false && dgvCliente.SelectedRows.Count == 1)
            {
                var a = dgvCliente.SelectedRows[0].Index;
                int idEntidadSeleccionada = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
                clienteSeleccionado = await DataLayer.Tasks.Cliente.seleccionar(idEntidadSeleccionada);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbNombreRazonSocial.Text = clienteSeleccionado.razon_social;
            }
        }

       

        private void bCancelar_Click_1(object sender, EventArgs e)
        {

            formState = "init";
            ChangeState();
        }
    }
}