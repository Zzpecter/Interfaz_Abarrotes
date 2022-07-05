namespace UI
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPrecioVenta = new System.Windows.Forms.NumericUpDown();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.bNuevoCliente = new System.Windows.Forms.Button();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNitCi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCambiarCantidad = new System.Windows.Forms.Button();
            this.bQuitar = new System.Windows.Forms.Button();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.lblOferta = new System.Windows.Forms.Label();
            this.btnAnularOferta = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnularOferta);
            this.groupBox2.Controls.Add(this.lblOferta);
            this.groupBox2.Controls.Add(this.tbPrecioVenta);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1076, 201);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.DecimalPlaces = 2;
            this.tbPrecioVenta.Enabled = false;
            this.tbPrecioVenta.Location = new System.Drawing.Point(226, 146);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.ReadOnly = true;
            this.tbPrecioVenta.Size = new System.Drawing.Size(165, 28);
            this.tbPrecioVenta.TabIndex = 52;
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
            this.bAgregar.Text = "Agregar a Venta";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBarcode);
            this.groupBox1.Controls.Add(this.bNuevoCliente);
            this.groupBox1.Controls.Add(this.tbNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNitCi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 97);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Cliente";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(356, 0);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(35, 28);
            this.tbBarcode.TabIndex = 40;
            this.tbBarcode.Visible = false;
            // 
            // bNuevoCliente
            // 
            this.bNuevoCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bNuevoCliente.Image = global::UI.Properties.Resources.agregar;
            this.bNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNuevoCliente.Location = new System.Drawing.Point(932, 31);
            this.bNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bNuevoCliente.Name = "bNuevoCliente";
            this.bNuevoCliente.Size = new System.Drawing.Size(137, 47);
            this.bNuevoCliente.TabIndex = 39;
            this.bNuevoCliente.Text = "Nuevo";
            this.bNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNuevoCliente.UseVisualStyleBackColor = false;
            this.bNuevoCliente.Click += new System.EventHandler(this.bNuevoCliente_Click);
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Enabled = false;
            this.tbNombreCliente.Location = new System.Drawing.Point(597, 39);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.ReadOnly = true;
            this.tbNombreCliente.Size = new System.Drawing.Size(313, 28);
            this.tbNombreCliente.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre:";
            // 
            // tbNitCi
            // 
            this.tbNitCi.Location = new System.Drawing.Point(100, 39);
            this.tbNitCi.Name = "tbNitCi";
            this.tbNitCi.Size = new System.Drawing.Size(291, 28);
            this.tbNitCi.TabIndex = 34;
            this.tbNitCi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNitCi_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "NIT/CI:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dgvVenta);
            this.groupBox3.Location = new System.Drawing.Point(12, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1076, 317);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venta Actual:";
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
            this.bVolver.Location = new System.Drawing.Point(7, 27);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(136, 64);
            this.bVolver.TabIndex = 47;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
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
            this.bGuardar.Text = "Efectuar Venta";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCambiarCantidad
            // 
            this.bCambiarCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCambiarCantidad.Enabled = false;
            this.bCambiarCantidad.Image = global::UI.Properties.Resources.refresh;
            this.bCambiarCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCambiarCantidad.Location = new System.Drawing.Point(225, 27);
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
            this.bQuitar.Location = new System.Drawing.Point(370, 27);
            this.bQuitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(137, 64);
            this.bQuitar.TabIndex = 38;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bQuitar.UseVisualStyleBackColor = false;
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AllowUserToResizeColumns = false;
            this.dgvVenta.AllowUserToResizeRows = false;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVenta.Location = new System.Drawing.Point(7, 27);
            this.dgvVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.RowTemplate.Height = 29;
            this.dgvVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(1062, 176);
            this.dgvVenta.TabIndex = 35;
            // 
            // lblOferta
            // 
            this.lblOferta.AutoSize = true;
            this.lblOferta.BackColor = System.Drawing.Color.White;
            this.lblOferta.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOferta.ForeColor = System.Drawing.Color.Green;
            this.lblOferta.Location = new System.Drawing.Point(446, 152);
            this.lblOferta.Name = "lblOferta";
            this.lblOferta.Size = new System.Drawing.Size(162, 20);
            this.lblOferta.TabIndex = 53;
            this.lblOferta.Text = "Precio de Oferta!";
            this.lblOferta.Visible = false;
            // 
            // btnAnularOferta
            // 
            this.btnAnularOferta.AutoSize = true;
            this.btnAnularOferta.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnularOferta.Location = new System.Drawing.Point(603, 152);
            this.btnAnularOferta.Name = "btnAnularOferta";
            this.btnAnularOferta.Size = new System.Drawing.Size(63, 20);
            this.btnAnularOferta.TabIndex = 54;
            this.btnAnularOferta.TabStop = true;
            this.btnAnularOferta.Text = "Anular";
            this.btnAnularOferta.Visible = false;
            this.btnAnularOferta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAnularOferta_LinkClicked);
            // 
            // FrmVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 627);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmVentas_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox tbNombreCliente;
        private Label label2;
        private TextBox tbNitCi;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox tbUnidades;
        private Label label5;
        private TextBox tbPresentacion;
        private Label label4;
        private TextBox tbNombreProducto;
        private Label label3;
        private Button bNuevoProducto;
        private Button bBuscar;
        private Button bNuevoCliente;
        private DataGridView dgvVenta;
        private Button bAgregar;
        private Label label7;
        private Label label8;
        private GroupBox groupBox4;
        private Button bCambiarCantidad;
        private Button bQuitar;
        private Label lblTotal;
        private Button bGuardar;
        private NumericUpDown tbPrecioVenta;
        private TextBox tbBarcode;
        private Button bVolver;
        private LinkLabel btnAnularOferta;
        private Label lblOferta;
    }
}