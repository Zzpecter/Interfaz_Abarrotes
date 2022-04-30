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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void bRegistroVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVentas frm = new FrmVentas();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bRegistroCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCompras frm = new FrmCompras();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bListadoVentas_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void bListadoCompras_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void bReportes_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerfil frm = new FrmPerfil();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuario frm = new FrmUsuario();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCliente frm = new FrmCliente();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProveedor frm = new FrmProveedor();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProductos frm = new FrmProductos();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bPresentaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPresentacionProducto frm = new FrmPresentacionProducto();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bUnidades_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUnidadesPresentacion frm = new FrmUnidadesPresentacion();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bAlmacenes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlmacenes frm = new FrmAlmacenes();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bLocalidades_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLocalidades frm = new FrmLocalidades();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuarioActual.Text = "Bienvenid@\n" + Sesion.login_usuario.ToUpperInvariant() +"!!";
        }
    }
}
