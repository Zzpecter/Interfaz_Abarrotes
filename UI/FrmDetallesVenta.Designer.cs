namespace UI
{
    partial class FrmDetallesVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallesVenta));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bImprimir = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.Location = new System.Drawing.Point(13, 140);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 29;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(694, 345);
            this.dgvProductos.TabIndex = 37;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 24);
            this.lblUsuario.TabIndex = 38;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(370, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(98, 24);
            this.lblCliente.TabIndex = 39;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Location = new System.Drawing.Point(414, 45);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(54, 24);
            this.lblNIT.TabIndex = 40;
            this.lblNIT.Text = "NIT:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 24);
            this.lblFecha.TabIndex = 41;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(524, 488);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 24);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Detalle:";
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bImprimir.Enabled = false;
            this.bImprimir.Image = global::UI.Properties.Resources.editar;
            this.bImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bImprimir.Location = new System.Drawing.Point(554, 525);
            this.bImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(156, 45);
            this.bImprimir.TabIndex = 45;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bImprimir.UseVisualStyleBackColor = false;
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(13, 525);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 44;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            // 
            // FrmDetallesVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 582);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNIT);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDetallesVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de Venta";
            this.Load += new System.EventHandler(this.FrmDetallesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblUsuario;
        private Label lblCliente;
        private Label lblNIT;
        private Label lblFecha;
        private Label lblTotal;
        private Label label5;
        private Button bImprimir;
        private Button bVolver;
    }
}