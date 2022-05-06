namespace UI
{
    partial class FrmListadoCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoCompras));
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.cbHasta = new System.Windows.Forms.CheckBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cbDesde = new System.Windows.Forms.CheckBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.rbFiltrarProveedor = new System.Windows.Forms.RadioButton();
            this.rbFiltrarTodo = new System.Windows.Forms.RadioButton();
            this.rbFiltrarFecha = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.bDetalles = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(12, 524);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 43;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNombreProveedor);
            this.groupBox2.Controls.Add(this.lblNombreCliente);
            this.groupBox2.Controls.Add(this.cbHasta);
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.cbDesde);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Controls.Add(this.rbFiltrarProveedor);
            this.groupBox2.Controls.Add(this.rbFiltrarTodo);
            this.groupBox2.Controls.Add(this.rbFiltrarFecha);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(955, 137);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // tbNombreProveedor
            // 
            this.tbNombreProveedor.Location = new System.Drawing.Point(413, 92);
            this.tbNombreProveedor.Name = "tbNombreProveedor";
            this.tbNombreProveedor.Size = new System.Drawing.Size(189, 28);
            this.tbNombreProveedor.TabIndex = 11;
            this.tbNombreProveedor.TextChanged += new System.EventHandler(this.tbNombreCliente_TextChanged);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(455, 65);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(87, 24);
            this.lblNombreCliente.TabIndex = 10;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // cbHasta
            // 
            this.cbHasta.AutoSize = true;
            this.cbHasta.Checked = true;
            this.cbHasta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHasta.Location = new System.Drawing.Point(100, 95);
            this.cbHasta.Name = "cbHasta";
            this.cbHasta.Size = new System.Drawing.Size(98, 28);
            this.cbHasta.TabIndex = 7;
            this.cbHasta.Text = "Hasta:";
            this.cbHasta.UseVisualStyleBackColor = true;
            this.cbHasta.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(204, 95);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(155, 28);
            this.dtpHasta.TabIndex = 6;
            // 
            // cbDesde
            // 
            this.cbDesde.AutoSize = true;
            this.cbDesde.Checked = true;
            this.cbDesde.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDesde.Location = new System.Drawing.Point(100, 61);
            this.cbDesde.Name = "cbDesde";
            this.cbDesde.Size = new System.Drawing.Size(98, 28);
            this.cbDesde.TabIndex = 5;
            this.cbDesde.Text = "Desde:";
            this.cbDesde.UseVisualStyleBackColor = true;
            this.cbDesde.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(204, 61);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(155, 28);
            this.dtpDesde.TabIndex = 4;
            // 
            // rbFiltrarProveedor
            // 
            this.rbFiltrarProveedor.AutoSize = true;
            this.rbFiltrarProveedor.Location = new System.Drawing.Point(390, 27);
            this.rbFiltrarProveedor.Name = "rbFiltrarProveedor";
            this.rbFiltrarProveedor.Size = new System.Drawing.Size(262, 28);
            this.rbFiltrarProveedor.TabIndex = 3;
            this.rbFiltrarProveedor.TabStop = true;
            this.rbFiltrarProveedor.Text = "Filtrar por Proveedor";
            this.rbFiltrarProveedor.UseVisualStyleBackColor = true;
            this.rbFiltrarProveedor.CheckedChanged += new System.EventHandler(this.rbFiltrar_CheckedChanged);
            // 
            // rbFiltrarTodo
            // 
            this.rbFiltrarTodo.AutoSize = true;
            this.rbFiltrarTodo.Location = new System.Drawing.Point(7, 27);
            this.rbFiltrarTodo.Name = "rbFiltrarTodo";
            this.rbFiltrarTodo.Size = new System.Drawing.Size(75, 28);
            this.rbFiltrarTodo.TabIndex = 1;
            this.rbFiltrarTodo.TabStop = true;
            this.rbFiltrarTodo.Text = "Todo";
            this.rbFiltrarTodo.UseVisualStyleBackColor = true;
            this.rbFiltrarTodo.CheckedChanged += new System.EventHandler(this.rbFiltrar_CheckedChanged);
            // 
            // rbFiltrarFecha
            // 
            this.rbFiltrarFecha.AutoSize = true;
            this.rbFiltrarFecha.Location = new System.Drawing.Point(100, 27);
            this.rbFiltrarFecha.Name = "rbFiltrarFecha";
            this.rbFiltrarFecha.Size = new System.Drawing.Size(218, 28);
            this.rbFiltrarFecha.TabIndex = 0;
            this.rbFiltrarFecha.TabStop = true;
            this.rbFiltrarFecha.Text = "Filtrar por Fecha";
            this.rbFiltrarFecha.UseVisualStyleBackColor = true;
            this.rbFiltrarFecha.CheckedChanged += new System.EventHandler(this.rbFiltrar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCompras);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 363);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeColumns = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompras.Location = new System.Drawing.Point(7, 27);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 29;
            this.dgvCompras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(941, 326);
            this.dgvCompras.TabIndex = 36;
            this.dgvCompras.SelectionChanged += new System.EventHandler(this.dgvCompras_SelectionChanged);
            // 
            // bDetalles
            // 
            this.bDetalles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bDetalles.Enabled = false;
            this.bDetalles.Image = global::UI.Properties.Resources.editar;
            this.bDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDetalles.Location = new System.Drawing.Point(772, 524);
            this.bDetalles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bDetalles.Name = "bDetalles";
            this.bDetalles.Size = new System.Drawing.Size(195, 45);
            this.bDetalles.TabIndex = 44;
            this.bDetalles.Text = "Ver Detalles";
            this.bDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDetalles.UseVisualStyleBackColor = false;
            this.bDetalles.Click += new System.EventHandler(this.bDetalles_Click);
            // 
            // FrmListadoCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 574);
            this.Controls.Add(this.bDetalles);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmListadoCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.FrmListadoCompras_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button bVolver;
        private GroupBox groupBox2;
        private TextBox tbNombreProveedor;
        private Label lblNombreCliente;
        private CheckBox cbHasta;
        private DateTimePicker dtpHasta;
        private CheckBox cbDesde;
        private DateTimePicker dtpDesde;
        private RadioButton rbFiltrarProveedor;
        private RadioButton rbFiltrarTodo;
        private RadioButton rbFiltrarFecha;
        private GroupBox groupBox1;
        private DataGridView dgvCompras;
        private Button bDetalles;
    }
}