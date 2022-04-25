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
    public partial class FrmSelectorCantidad : Form
    {
        public Decimal cantidad;
        public FrmSelectorCantidad(bool permite_cantidad_fraccionada)
        {
            InitializeComponent();
            if (permite_cantidad_fraccionada)
            {
                tbCantidad.DecimalPlaces = 2;
                tbCantidad.Minimum = Convert.ToDecimal(0.01);
                tbCantidad.Value = Convert.ToDecimal(0.01);
            }
            else
            {
                tbCantidad.DecimalPlaces = 0;
                tbCantidad.Minimum = 1;
                tbCantidad.Value = 1;
            }
            cantidad = tbCantidad.Value;
        }

        private void FrmSelectorCantidad_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            cantidad = tbCantidad.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
