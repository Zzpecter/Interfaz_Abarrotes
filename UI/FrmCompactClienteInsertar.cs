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
    public partial class FrmCompactClienteInsertar : Form
    {
        public DataLayer.Models.ViCliente viCliente;
        public FrmCompactClienteInsertar()
        {
            InitializeComponent();
            viCliente = new DataLayer.Models.ViCliente() { id_entidad = -1 };
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbNitCi.Text.Length > 4 && tbNombreRazonSocial.Text != String.Empty)
            {
                //chekear si el nit ya existe
                viCliente = await DataLayer.Tasks.Cliente.seleccionarPorNit(tbNitCi.Text);
                if (viCliente.id_entidad == -1)
                {
                    DataLayer.Models.Cliente cliente = new DataLayer.Models.Cliente() 
                    {
                        razon_social = tbNombreRazonSocial.Text,
                        nit_ci = tbNitCi.Text,
                        usuario_registro = Sesion.login_usuario
                    };

                    viCliente = await DataLayer.Tasks.Cliente.insertar(cliente);
                    viCliente.nit_ci = cliente.nit_ci;
                    viCliente.razon_social = cliente.razon_social;

                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ya existe un cliente con ese NIT/CI!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("NIT/CI Inválido o Nombre vacío.\nVerifique si los datos fueron ingresados correctamente!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
