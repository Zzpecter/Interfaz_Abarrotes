namespace UI
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEditarPresentaciones = new System.Windows.Forms.Button();
            this.tbPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.tbPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigoProducto = new System.Windows.Forms.TextBox();
            this.cmbPresentaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.bElimiar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bReestablecer = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEditarPresentaciones);
            this.groupBox1.Controls.Add(this.tbPrecioVenta);
            this.groupBox1.Controls.Add(this.tbPrecioCompra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCodigoProducto);
            this.groupBox1.Controls.Add(this.cmbPresentaciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNombreProducto);
            this.groupBox1.Location = new System.Drawing.Point(13, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 180);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto Seleccionado";
            // 
            // bEditarPresentaciones
            // 
            this.bEditarPresentaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bEditarPresentaciones.Enabled = false;
            this.bEditarPresentaciones.Image = global::UI.Properties.Resources.editar_small;
            this.bEditarPresentaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditarPresentaciones.Location = new System.Drawing.Point(528, 119);
            this.bEditarPresentaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEditarPresentaciones.Name = "bEditarPresentaciones";
            this.bEditarPresentaciones.Size = new System.Drawing.Size(108, 32);
            this.bEditarPresentaciones.TabIndex = 31;
            this.bEditarPresentaciones.Text = "Editar";
            this.bEditarPresentaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditarPresentaciones.UseVisualStyleBackColor = false;
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.DecimalPlaces = 2;
            this.tbPrecioVenta.Location = new System.Drawing.Point(745, 83);
            this.tbPrecioVenta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbPrecioVenta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(150, 28);
            this.tbPrecioVenta.TabIndex = 27;
            // 
            // tbPrecioCompra
            // 
            this.tbPrecioCompra.DecimalPlaces = 2;
            this.tbPrecioCompra.Location = new System.Drawing.Point(745, 49);
            this.tbPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrecioCompra.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbPrecioCompra.Name = "tbPrecioCompra";
            this.tbPrecioCompra.Size = new System.Drawing.Size(150, 28);
            this.tbPrecioCompra.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Precio Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Código del Producto:";
            // 
            // tbCodigoProducto
            // 
            this.tbCodigoProducto.Enabled = false;
            this.tbCodigoProducto.Location = new System.Drawing.Point(243, 83);
            this.tbCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCodigoProducto.Name = "tbCodigoProducto";
            this.tbCodigoProducto.Size = new System.Drawing.Size(278, 28);
            this.tbCodigoProducto.TabIndex = 22;
            // 
            // cmbPresentaciones
            // 
            this.cmbPresentaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresentaciones.FormattingEnabled = true;
            this.cmbPresentaciones.Location = new System.Drawing.Point(266, 120);
            this.cmbPresentaciones.Name = "cmbPresentaciones";
            this.cmbPresentaciones.Size = new System.Drawing.Size(255, 32);
            this.cmbPresentaciones.TabIndex = 21;
            this.cmbPresentaciones.SelectedIndexChanged += new System.EventHandler(this.cmbPresentaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Presentacion/Unidades:";
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Enabled = false;
            this.tbNombreProducto.Location = new System.Drawing.Point(243, 49);
            this.tbNombreProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(278, 28);
            this.tbNombreProducto.TabIndex = 15;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(962, 537);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 27;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bGuardar.Image = global::UI.Properties.Resources.guardar;
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGuardar.Location = new System.Drawing.Point(962, 486);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(139, 45);
            this.bGuardar.TabIndex = 26;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatos.Location = new System.Drawing.Point(7, 78);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 29;
            this.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(928, 293);
            this.dgvDatos.TabIndex = 28;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // bElimiar
            // 
            this.bElimiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bElimiar.Enabled = false;
            this.bElimiar.Image = global::UI.Properties.Resources.eliminar;
            this.bElimiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bElimiar.Location = new System.Drawing.Point(962, 120);
            this.bElimiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bElimiar.Name = "bElimiar";
            this.bElimiar.Size = new System.Drawing.Size(139, 45);
            this.bElimiar.TabIndex = 25;
            this.bElimiar.Text = "Eliminar";
            this.bElimiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bElimiar.UseVisualStyleBackColor = false;
            this.bElimiar.Click += new System.EventHandler(this.bElimiar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bActualizar.Enabled = false;
            this.bActualizar.Image = global::UI.Properties.Resources.editar;
            this.bActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bActualizar.Location = new System.Drawing.Point(962, 69);
            this.bActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(139, 45);
            this.bActualizar.TabIndex = 24;
            this.bActualizar.Text = "Editar";
            this.bActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bActualizar.UseVisualStyleBackColor = false;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAgregar.Image = global::UI.Properties.Resources.agregar;
            this.bAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAgregar.Location = new System.Drawing.Point(962, 21);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(139, 45);
            this.bAgregar.TabIndex = 23;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bReestablecer);
            this.groupBox2.Controls.Add(this.tbBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvDatos);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 385);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // bReestablecer
            // 
            this.bReestablecer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReestablecer.Enabled = false;
            this.bReestablecer.Image = global::UI.Properties.Resources.clear;
            this.bReestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReestablecer.Location = new System.Drawing.Point(722, 40);
            this.bReestablecer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bReestablecer.Name = "bReestablecer";
            this.bReestablecer.Size = new System.Drawing.Size(173, 32);
            this.bReestablecer.TabIndex = 32;
            this.bReestablecer.Text = "Reestablecer";
            this.bReestablecer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReestablecer.UseVisualStyleBackColor = false;
            this.bReestablecer.Click += new System.EventHandler(this.bReestablecer_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(169, 44);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(545, 28);
            this.tbBuscar.TabIndex = 26;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Buscar:";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(13, 596);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 31;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 653);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bElimiar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown tbPrecioVenta;
        private NumericUpDown tbPrecioCompra;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox tbCodigoProducto;
        private ComboBox cmbPresentaciones;
        private Label label1;
        private Label label3;
        private TextBox tbNombreProducto;
        private Button bCancelar;
        private Button bGuardar;
        private DataGridView dgvDatos;
        private Button bElimiar;
        private Button bActualizar;
        private Button bAgregar;
        private GroupBox groupBox2;
        private TextBox tbBuscar;
        private Label label5;
        private Button bEditarPresentaciones;
        private Button bVolver;
        private Button bReestablecer;
    }
}