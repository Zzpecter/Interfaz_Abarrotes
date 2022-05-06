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
    public partial class FrmDetallesCompra : Form
    {
        private int idCompra;
        private DataLayer.Models.ViCompraProveedor compraActual;
        private DataLayer.Models.ViProveedor proveedorActual;
        private DataLayer.Models.ViUsuario usuarioActual;
        private List<DataLayer.Models.ViDetalleEntradaProducto> detallesCompra;
        private DataTable dtDatos;
        private bool loading;

        public FrmDetallesCompra(int idCompra)
        {
            InitializeComponent();
            this.idCompra = idCompra;
            detallesCompra = new List<DataLayer.Models.ViDetalleEntradaProducto>();
        }

        private async void FrmDetallesCompra_Load(object sender, EventArgs e)
        {
            compraActual = await DataLayer.Tasks.Compra.seleccionarCompraProveedor(this.idCompra);

            usuarioActual = await DataLayer.Tasks.Usuario.seleccionar(this.compraActual.id_usuario);
            proveedorActual = await DataLayer.Tasks.Proveedor.seleccionar(this.compraActual.id_proveedor);

            detallesCompra = await DataLayer.Tasks.DetalleEntrada.seleccionarPorCompra(this.idCompra);

            CreateDataSource();
        }

        private void CreateDataSource()
        {
            //Llenar los labels
            lblProveedor.Text = "Proveedor: " + proveedorActual.nombre;
            lblUsuario.Text = "Usuario: " + usuarioActual.login_usuario;
            lblFecha.Text = "Fecha: " + compraActual.fecha.ToShortDateString();
            lblTotal.Text = "Total: " + compraActual.monto_total.ToString() + " Bs.";

            //De aqui abajo solo llena el datagrid
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(detallesCompra[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < detallesCompra.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(detallesCompra[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }

            dtDatos.Columns.Remove("id_detalle_entrada");
            dtDatos.Columns.Remove("id_compra");
            dtDatos.Columns.Remove("id_producto");
            dtDatos.Columns.Remove("id_presentacion_producto");
            dtDatos.Columns.Remove("id_unidad_presentacion");

            dtDatos.Columns["producto"].SetOrdinal(0);
            dtDatos.Columns["presentacion"].SetOrdinal(1);
            dtDatos.Columns["unidades"].SetOrdinal(2);
            dtDatos.Columns["cantidad"].SetOrdinal(3);
            dtDatos.Columns["precio_unidad"].SetOrdinal(4);

            dgvProductos.DataSource = dtDatos;
            dgvProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvProductos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvProductos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvProductos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Refresh();
            dgvProductos.ClearSelection();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
