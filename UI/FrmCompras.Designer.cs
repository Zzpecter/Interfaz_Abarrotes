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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCambiarCantidad = new System.Windows.Forms.Button();
            this.bQuitar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEditarAlmacenes = new System.Windows.Forms.Button();
            this.cmbAlmacenDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bEditarProveedores = new System.Windows.Forms.Button();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUnidades = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPresentacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bNuevoProducto = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dgvCompra);
            this.groupBox3.Location = new System.Drawing.Point(12, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1076, 317);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compra Actual:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bVolver);
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.bGuardar);
            this.groupBox4.Controls.Add(this.bCambiarCantidad);
            this.groupBox4.Controls.Add(this.bQuitar);
            this.groupBox4.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(6, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1062, 97);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(1, 27);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(136, 64);
            this.bVolver.TabIndex = 48;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(590, 42);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(169, 30);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Total: 0 Bs.";
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bGuardar.Image = global::UI.Properties.Resources.guardar;
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGuardar.Location = new System.Drawing.Point(897, 27);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(158, 64);
            this.bGuardar.TabIndex = 45;
            this.bGuardar.Text = "Efectuar Compra";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            // 
            // bCambiarCantidad
            // 
            this.bCambiarCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCambiarCantidad.Enabled = false;
            this.bCambiarCantidad.Image = global::UI.Properties.Resources.refresh;
            this.bCambiarCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCambiarCantidad.Location = new System.Drawing.Point(181, 27);
            this.bCambiarCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCambiarCantidad.Name = "bCambiarCantidad";
            this.bCambiarCantidad.Size = new System.Drawing.Size(137, 64);
            this.bCambiarCantidad.TabIndex = 39;
            this.bCambiarCantidad.Text = "Cambiar Cantidad";
            this.bCambiarCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCambiarCantidad.UseVisualStyleBackColor = false;
            // 
            // bQuitar
            // 
            this.bQuitar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bQuitar.Enabled = false;
            this.bQuitar.Image = global::UI.Properties.Resources.cancelar;
            this.bQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bQuitar.Location = new System.Drawing.Point(326, 27);
            this.bQuitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(137, 64);
            this.bQuitar.TabIndex = 38;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bQuitar.UseVisualStyleBackColor = false;
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AllowUserToResizeColumns = false;
            this.dgvCompra.AllowUserToResizeRows = false;
            this.dgvCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompra.Location = new System.Drawing.Point(7, 27);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowHeadersVisible = false;
            this.dgvCompra.RowHeadersWidth = 51;
            this.dgvCompra.RowTemplate.Height = 29;
            this.dgvCompra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(1062, 176);
            this.dgvCompra.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEditarAlmacenes);
            this.groupBox1.Controls.Add(this.cmbAlmacenDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bEditarProveedores);
            this.groupBox1.Controls.Add(this.cmbProveedores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbBarcode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 97);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Compra";
            // 
            // bEditarAlmacenes
            // 
            this.bEditarAlmacenes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bEditarAlmacenes.Enabled = false;
            this.bEditarAlmacenes.Image = global::UI.Properties.Resources.agregar;
            this.bEditarAlmacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditarAlmacenes.Location = new System.Drawing.Point(932, 28);
            this.bEditarAlmacenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEditarAlmacenes.Name = "bEditarAlmacenes";
            this.bEditarAlmacenes.Size = new System.Drawing.Size(132, 53);
            this.bEditarAlmacenes.TabIndex = 46;
            this.bEditarAlmacenes.Text = "Agregar";
            this.bEditarAlmacenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditarAlmacenes.UseVisualStyleBackColor = false;
            this.bEditarAlmacenes.Click += new System.EventHandler(this.bEditarAlmacenes_Click);
            // 
            // cmbAlmacenDestino
            // 
            this.cmbAlmacenDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmacenDestino.FormattingEnabled = true;
            this.cmbAlmacenDestino.Location = new System.Drawing.Point(670, 39);
            this.cmbAlmacenDestino.Name = "cmbAlmacenDestino";
            this.cmbAlmacenDestino.Size = new System.Drawing.Size(255, 32);
            this.cmbAlmacenDestino.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Almacen:";
            // 
            // bEditarProveedores
            // 
            this.bEditarProveedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bEditarProveedores.Enabled = false;
            this.bEditarProveedores.Image = global::UI.Properties.Resources.agregar;
            this.bEditarProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditarProveedores.Location = new System.Drawing.Point(406, 28);
            this.bEditarProveedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEditarProveedores.Name = "bEditarProveedores";
            this.bEditarProveedores.Size = new System.Drawing.Size(132, 53);
            this.bEditarProveedores.TabIndex = 43;
            this.bEditarProveedores.Text = "Agregar";
            this.bEditarProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditarProveedores.UseVisualStyleBackColor = false;
            this.bEditarProveedores.Click += new System.EventHandler(this.bEditarProveedores_Click);
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(144, 39);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(255, 32);
            this.cmbProveedores.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Proveedor:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(356, 0);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(35, 28);
            this.tbBarcode.TabIndex = 40;
            this.tbBarcode.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPrecioCompra);
            this.groupBox2.Controls.Add(this.bAgregar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbUnidades);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbPresentacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbNombreProducto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bNuevoProducto);
            this.groupBox2.Controls.Add(this.bBuscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1076, 201);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // tbPrecioCompra
            // 
            this.tbPrecioCompra.DecimalPlaces = 2;
            this.tbPrecioCompra.Enabled = false;
            this.tbPrecioCompra.Location = new System.Drawing.Point(226, 146);
            this.tbPrecioCompra.Name = "tbPrecioCompra";
            this.tbPrecioCompra.ReadOnly = true;
            this.tbPrecioCompra.Size = new System.Drawing.Size(165, 28);
            this.tbPrecioCompra.TabIndex = 52;
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAgregar.Enabled = false;
            this.bAgregar.Image = global::UI.Properties.Resources.cart;
            this.bAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAgregar.Location = new System.Drawing.Point(838, 137);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(231, 47);
            this.bAgregar.TabIndex = 51;
            this.bAgregar.Text = "Agregar a Compra";
            this.bAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "Bs.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Precio Unitario:";
            // 
            // tbUnidades
            // 
            this.tbUnidades.Enabled = false;
            this.tbUnidades.Location = new System.Drawing.Point(537, 92);
            this.tbUnidades.Name = "tbUnidades";
            this.tbUnidades.Size = new System.Drawing.Size(270, 28);
            this.tbUnidades.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Unidades:";
            // 
            // tbPresentacion
            // 
            this.tbPresentacion.Enabled = false;
            this.tbPresentacion.Location = new System.Drawing.Point(166, 92);
            this.tbPresentacion.Name = "tbPresentacion";
            this.tbPresentacion.Size = new System.Drawing.Size(225, 28);
            this.tbPresentacion.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Presentacion:";
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Enabled = false;
            this.tbNombreProducto.Location = new System.Drawing.Point(100, 39);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(707, 28);
            this.tbNombreProducto.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nombre:";
            // 
            // bNuevoProducto
            // 
            this.bNuevoProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bNuevoProducto.Image = global::UI.Properties.Resources.agregar;
            this.bNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNuevoProducto.Location = new System.Drawing.Point(932, 84);
            this.bNuevoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bNuevoProducto.Name = "bNuevoProducto";
            this.bNuevoProducto.Size = new System.Drawing.Size(137, 47);
            this.bNuevoProducto.TabIndex = 38;
            this.bNuevoProducto.Text = "Nuevo";
            this.bNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNuevoProducto.UseVisualStyleBackColor = false;
            this.bNuevoProducto.Click += new System.EventHandler(this.bNuevoProducto_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bBuscar.Image = global::UI.Properties.Resources.search1;
            this.bBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscar.Location = new System.Drawing.Point(932, 31);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(137, 47);
            this.bBuscar.TabIndex = 37;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 650);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCompras_KeyPress);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblTotal;
        private Button bGuardar;
        private Button bCambiarCantidad;
        private Button bQuitar;
        private DataGridView dgvCompra;
        private GroupBox groupBox1;
        private TextBox tbBarcode;
        private GroupBox groupBox2;
        private NumericUpDown tbPrecioCompra;
        private Button bAgregar;
        private Label label7;
        private Label label8;
        private TextBox tbUnidades;
        private Label label5;
        private TextBox tbPresentacion;
        private Label label4;
        private TextBox tbNombreProducto;
        private Label label3;
        private Button bNuevoProducto;
        private Button bBuscar;
        private Button bEditarAlmacenes;
        private ComboBox cmbAlmacenDestino;
        private Label label2;
        private Button bEditarProveedores;
        private ComboBox cmbProveedores;
        private Label label1;
        private Button bVolver;
    }
}