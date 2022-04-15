namespace UI
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bNuevoProducto = new System.Windows.Forms.Button();
            this.bReestablecer = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCompraActual = new System.Windows.Forms.DataGridView();
            this.tbCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.bNuevoProveedor = new System.Windows.Forms.Button();
            this.bEditarAlmacenes = new System.Windows.Forms.Button();
            this.cmbAlmacenDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bNuevoProducto);
            this.groupBox2.Controls.Add(this.bReestablecer);
            this.groupBox2.Controls.Add(this.tbBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvProductos);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 385);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // bNuevoProducto
            // 
            this.bNuevoProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bNuevoProducto.Image = global::UI.Properties.Resources.editar_small;
            this.bNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNuevoProducto.Location = new System.Drawing.Point(541, 39);
            this.bNuevoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bNuevoProducto.Name = "bNuevoProducto";
            this.bNuevoProducto.Size = new System.Drawing.Size(95, 32);
            this.bNuevoProducto.TabIndex = 33;
            this.bNuevoProducto.Text = "Nuevo";
            this.bNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNuevoProducto.UseVisualStyleBackColor = false;
            // 
            // bReestablecer
            // 
            this.bReestablecer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReestablecer.Enabled = false;
            this.bReestablecer.Image = global::UI.Properties.Resources.clear;
            this.bReestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReestablecer.Location = new System.Drawing.Point(421, 39);
            this.bReestablecer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bReestablecer.Name = "bReestablecer";
            this.bReestablecer.Size = new System.Drawing.Size(112, 32);
            this.bReestablecer.TabIndex = 32;
            this.bReestablecer.Text = "Limpiar";
            this.bReestablecer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReestablecer.UseVisualStyleBackColor = false;
            this.bReestablecer.Click += new System.EventHandler(this.bReestablecer_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(101, 43);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(312, 28);
            this.tbBuscar.TabIndex = 26;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Buscar:";
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
            this.dgvProductos.Location = new System.Drawing.Point(7, 78);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 29;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(629, 293);
            this.dgvProductos.TabIndex = 28;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // bQuitar
            // 
            this.bQuitar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bQuitar.BackgroundImage = global::UI.Properties.Resources.arrow_left;
            this.bQuitar.Enabled = false;
            this.bQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bQuitar.Location = new System.Drawing.Point(679, 177);
            this.bQuitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(82, 82);
            this.bQuitar.TabIndex = 32;
            this.bQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bQuitar.UseVisualStyleBackColor = false;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAgregar.BackgroundImage = global::UI.Properties.Resources.arrow_right;
            this.bAgregar.Enabled = false;
            this.bAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAgregar.Location = new System.Drawing.Point(679, 89);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(82, 82);
            this.bAgregar.TabIndex = 31;
            this.bAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCompraActual);
            this.groupBox1.Location = new System.Drawing.Point(781, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 385);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra Actual";
            // 
            // dgvCompraActual
            // 
            this.dgvCompraActual.AllowUserToAddRows = false;
            this.dgvCompraActual.AllowUserToDeleteRows = false;
            this.dgvCompraActual.AllowUserToResizeColumns = false;
            this.dgvCompraActual.AllowUserToResizeRows = false;
            this.dgvCompraActual.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompraActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompraActual.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCompraActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraActual.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompraActual.Location = new System.Drawing.Point(7, 43);
            this.dgvCompraActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCompraActual.Name = "dgvCompraActual";
            this.dgvCompraActual.RowHeadersVisible = false;
            this.dgvCompraActual.RowHeadersWidth = 51;
            this.dgvCompraActual.RowTemplate.Height = 29;
            this.dgvCompraActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCompraActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompraActual.Size = new System.Drawing.Size(629, 328);
            this.dgvCompraActual.TabIndex = 28;
            this.dgvCompraActual.SelectionChanged += new System.EventHandler(this.dgvCompraActual_SelectionChanged);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(688, 288);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(62, 28);
            this.tbCantidad.TabIndex = 39;
            this.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCantidad_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cantidad:";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(12, 433);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 40;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bGuardar.Image = global::UI.Properties.Resources.guardar;
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGuardar.Location = new System.Drawing.Point(1207, 482);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(222, 45);
            this.bGuardar.TabIndex = 41;
            this.bGuardar.Text = "Efectuar Compra";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Precio/U";
            // 
            // tbPrecio
            // 
            this.tbPrecio.DecimalPlaces = 2;
            this.tbPrecio.Location = new System.Drawing.Point(669, 364);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(105, 28);
            this.tbPrecio.TabIndex = 43;
            this.tbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(965, 487);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 30);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(781, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Proveedor:";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(923, 12);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(360, 32);
            this.cmbProveedores.TabIndex = 46;
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            // 
            // bNuevoProveedor
            // 
            this.bNuevoProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bNuevoProveedor.Image = global::UI.Properties.Resources.editar_small;
            this.bNuevoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNuevoProveedor.Location = new System.Drawing.Point(1290, 12);
            this.bNuevoProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bNuevoProveedor.Name = "bNuevoProveedor";
            this.bNuevoProveedor.Size = new System.Drawing.Size(95, 32);
            this.bNuevoProveedor.TabIndex = 34;
            this.bNuevoProveedor.Text = "Nuevo";
            this.bNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNuevoProveedor.UseVisualStyleBackColor = false;
            // 
            // bEditarAlmacenes
            // 
            this.bEditarAlmacenes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bEditarAlmacenes.Image = global::UI.Properties.Resources.editar_small;
            this.bEditarAlmacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditarAlmacenes.Location = new System.Drawing.Point(1323, 440);
            this.bEditarAlmacenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEditarAlmacenes.Name = "bEditarAlmacenes";
            this.bEditarAlmacenes.Size = new System.Drawing.Size(104, 32);
            this.bEditarAlmacenes.TabIndex = 47;
            this.bEditarAlmacenes.Text = "Editar";
            this.bEditarAlmacenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditarAlmacenes.UseVisualStyleBackColor = false;
            // 
            // cmbAlmacenDestino
            // 
            this.cmbAlmacenDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmacenDestino.FormattingEnabled = true;
            this.cmbAlmacenDestino.Location = new System.Drawing.Point(1008, 441);
            this.cmbAlmacenDestino.Name = "cmbAlmacenDestino";
            this.cmbAlmacenDestino.Size = new System.Drawing.Size(308, 32);
            this.cmbAlmacenDestino.TabIndex = 49;
            this.cmbAlmacenDestino.SelectedIndexChanged += new System.EventHandler(this.cmbAlmacenDestino_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Almacen Destino:";
            // 
            // FrmCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1446, 539);
            this.Controls.Add(this.bEditarAlmacenes);
            this.Controls.Add(this.cmbAlmacenDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bNuevoProveedor);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private Button bReestablecer;
        private TextBox tbBuscar;
        private Label label5;
        private DataGridView dgvProductos;
        private Button bQuitar;
        private Button bAgregar;
        private GroupBox groupBox1;
        private DataGridView dgvCompraActual;
        private NumericUpDown tbCantidad;
        private Label label2;
        private Button bVolver;
        private Button bGuardar;
        private Label label1;
        private NumericUpDown tbPrecio;
        private Button bNuevoProducto;
        private Label lblTotal;
        private Label label3;
        private Button bNuevoProveedor;
        private ComboBox cmbProveedores;
        private Button bEditarAlmacenes;
        private ComboBox cmbAlmacenDestino;
        private Label label4;
    }
}