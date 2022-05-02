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
    public partial class FrmDetallesVenta : Form
    {
        private int idVenta;
        private DataLayer.Models.ViVentaCliente ventaActual;
        private DataLayer.Models.ViCliente clienteActual;
        private DataLayer.Models.ViUsuario usuarioActual;
        private List<DataLayer.Models.ViDetalleSalidaProducto> detallesVenta;
        private DataTable dtDatos;
        private bool loading;

        public FrmDetallesVenta(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
            detallesVenta = new List<DataLayer.Models.ViDetalleSalidaProducto>();
        }

        private async void FrmDetallesVenta_Load(object sender, EventArgs e)
        {
            ventaActual = await DataLayer.Tasks.Venta.seleccionarVentaCliente(this.idVenta);

            usuarioActual = await DataLayer.Tasks.Usuario.seleccionar(this.ventaActual.id_usuario);
            clienteActual = await DataLayer.Tasks.Cliente.seleccionar(this.ventaActual.id_cliente);

            detallesVenta = await DataLayer.Tasks.DetalleSalida.seleccionarPorVenta(this.idVenta);

            CreateDataSource();
        }

        private void CreateDataSource()
        {
            //Llenar los labels
            lblCliente.Text = "Cliente: " + clienteActual.razon_social;
            lblNIT.Text = "NIT/CI:" + clienteActual.nit_ci;
            lblUsuario.Text = "Usuario: " + usuarioActual.login_usuario;
            lblFecha.Text = "Fecha: " + ventaActual.fecha.ToShortDateString();
            lblTotal.Text = "Total: " + ventaActual.monto_total.ToString() + " Bs.";
            
            //De aqui abajo solo llena el datagrid
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(detallesVenta[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < detallesVenta.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(detallesVenta[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }

            dtDatos.Columns.Remove("id_detalle_salida");
            dtDatos.Columns.Remove("id_salida_producto");
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
    }
}
