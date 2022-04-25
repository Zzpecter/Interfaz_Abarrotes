using System;
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
    public partial class FrmCompactProductoBuscar : Form
    {
        private List<DataLayer.Models.ViProductoEnAlmacen> productosEnAlmacen;
        public DataLayer.Models.ViProductoEnAlmacen productoSeleccionado;
        private DataTable dtDatos;

        private bool loading;
        public FrmCompactProductoBuscar()
        {
            InitializeComponent();
        }

        private async void FrmCompactProductoBuscar_Load(object sender, EventArgs e)
        {
            await DataLayer.Tasks.Authentication.BuildAuthHeaders(); // Esto se hará en el login, cuando exista.

            productosEnAlmacen = await DataLayer.Tasks.ProductoAlmacen.listarProductoEnAlmacen();
            CreateDataSource(productosEnAlmacen);
        }

        private void CreateDataSource(List<DataLayer.Models.ViProductoEnAlmacen> productos)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(productos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < productos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(productos[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns.Remove("id_presentacion_producto");
            dtDatos.Columns.Remove("id_unidad_presentacion");
            dtDatos.Columns.Remove("id_almacen");
            dtDatos.Columns.Remove("multiplicador_kg");
            dtDatos.Columns["id_producto"].SetOrdinal(0);
            dtDatos.Columns["nombre"].SetOrdinal(1);
            dtDatos.Columns["codigo"].SetOrdinal(2);
            dtDatos.Columns["precio_compra"].SetOrdinal(3);
            dtDatos.Columns["precio_venta"].SetOrdinal(4);
            dtDatos.Columns["presentacion"].SetOrdinal(5);
            dtDatos.Columns["unidades"].SetOrdinal(6);
            dtDatos.Columns["almacen"].SetOrdinal(7);
            dgvDatos.DataSource = dtDatos;
            dgvDatos.Columns[1].HeaderText = "Nombre Producto";
            dgvDatos.Columns[2].HeaderText = "Código";
            dgvDatos.Columns[3].HeaderText = "Precio Compra (Bs)";
            dgvDatos.Columns[4].HeaderText = "Precio Venta (Bs)";
            dgvDatos.Columns[5].HeaderText = "Presentación";
            dgvDatos.Columns[6].HeaderText = "Unidades";
            dgvDatos.Columns[7].HeaderText = "Almacen";
            dgvDatos.Columns[0].Width = 0;
            dgvDatos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDatos.Refresh();
            dgvDatos.ClearSelection();
            this.loading = false;
        }

        private async void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvDatos.SelectedRows.Count == 1)
            {
                int idProductoSeleccionado = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                this.productoSeleccionado = await DataLayer.Tasks.ProductoAlmacen.seleccionarProductoEnAlmacen(idProductoSeleccionado);
            }
        }

        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.productoSeleccionado.id_producto != -1)
                this.DialogResult = DialogResult.OK;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbBuscar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private async void tbBuscar_TextChanged(object sender, EventArgs e)
        {

            if (!loading && tbBuscar.Text != String.Empty)
            {
                bReestablecer.Enabled = true;
                List<DataLayer.Models.ViProductoEnAlmacen> productos = await DataLayer.Tasks.ProductoAlmacen.buscarProductoEnAlmacen(tbBuscar.Text);
                if (productos.Count > 0)
                    CreateDataSource(productos);
                else
                {
                    dgvDatos.DataSource = null;
                }
            }
        }
    }
}
