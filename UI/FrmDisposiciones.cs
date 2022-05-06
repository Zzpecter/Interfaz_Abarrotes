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
    public partial class FrmDisposiciones : Form
    {
        #region Variables e Inicializacion
        private List<DataLayer.Models.ViDisposicionCompleto> disposiciones;
        private DataTable dtDatos;
        private bool loading;
        public FrmDisposiciones()
        {
            InitializeComponent();
            disposiciones = new List<DataLayer.Models.ViDisposicionCompleto>();
        }

        private async void FrmDisposiciones_Load(object sender, EventArgs e)
        {
            CreateDataSource();
        }
        #endregion
        #region Botones y Controles
        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bNuevaDisposicion_Click(object sender, EventArgs e)
        {
            FrmCompactDisposicionInsertar frm = new FrmCompactDisposicionInsertar();
            frm.ShowDialog();
            //Actualizar el datasource 
            CreateDataSource();
        }
        #endregion

        #region Métodos Auxiliares
        private async void CreateDataSource()
        {
            disposiciones = await DataLayer.Tasks.Disposicion.listar();
            if (disposiciones.Count > 0)
            {
                dtDatos = new DataTable();
                dtDatos.Clear();

                //metodo de ayuda para convertir las propiedades de una instancia en un dict.
                Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.disposiciones[0]);

                //Agregamos columnas segun los atributos del objeto 
                foreach (var item in propertyDict)
                    dtDatos.Columns.Add(item.Key);
                //Agregamos filas
                for (int i = 0; i < this.disposiciones.Count; i++)
                {
                    propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.disposiciones[i]);
                    DataRow _tempRow = dtDatos.NewRow();
                    foreach (var item in propertyDict)
                        _tempRow[item.Key] = item.Value;
                    dtDatos.Rows.Add(_tempRow);
                }

                loading = true;
                dtDatos.Columns.Remove("id_usuario");
                dtDatos.Columns.Remove("id_motivo");
                dtDatos.Columns.Remove("id_producto");

                dtDatos.Columns["id_salida_producto"].SetOrdinal(0);
                dtDatos.Columns["fecha"].SetOrdinal(1);
                dtDatos.Columns["producto"].SetOrdinal(2);
                dtDatos.Columns["descripcion_motivo"].SetOrdinal(3);
                dtDatos.Columns["cantidad"].SetOrdinal(4);
                dtDatos.Columns["comentario"].SetOrdinal(5);
                dtDatos.Columns["usuario"].SetOrdinal(6);

                dgvDisposiciones.DataSource = dtDatos;
                dgvDisposiciones.Columns[0].Width = 0;
                dgvDisposiciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDisposiciones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDisposiciones.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                dgvDisposiciones.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDisposiciones.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDisposiciones.Refresh();
                dgvDisposiciones.ClearSelection();
                loading = false;
            }
            else
            {
                dgvDisposiciones.DataSource = null;
                dgvDisposiciones.Refresh();
            }
        }
        #endregion
    }
}
