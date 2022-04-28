namespace UI
{
    partial class FrmCompactProductoCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompactProductoCrear));
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
            this.cbGenerarCodigo = new System.Windows.Forms.CheckBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // bEditarPresentaciones
            // 
            this.bEditarPresentaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bEditarPresentaciones.Image = global::UI.Properties.Resources.editar_small;
            this.bEditarPresentaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditarPresentaciones.Location = new System.Drawing.Point(634, 113);
            this.bEditarPresentaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEditarPresentaciones.Name = "bEditarPresentaciones";
            this.bEditarPresentaciones.Size = new System.Drawing.Size(108, 32);
            this.bEditarPresentaciones.TabIndex = 31;
            this.bEditarPresentaciones.Text = "Editar";
            this.bEditarPresentaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditarPresentaciones.UseVisualStyleBackColor = false;
            this.bEditarPresentaciones.Click += new System.EventHandler(this.bEditarPresentaciones_Click);
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.DecimalPlaces = 2;
            this.tbPrecioVenta.Location = new System.Drawing.Point(590, 76);
            this.tbPrecioVenta.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbPrecioVenta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbPrecioVenta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(138, 28);
            this.tbPrecioVenta.TabIndex = 27;
            this.tbPrecioVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // tbPrecioCompra
            // 
            this.tbPrecioCompra.DecimalPlaces = 2;
            this.tbPrecioCompra.Location = new System.Drawing.Point(251, 76);
            this.tbPrecioCompra.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbPrecioCompra.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbPrecioCompra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbPrecioCompra.Name = "tbPrecioCompra";
            this.tbPrecioCompra.Size = new System.Drawing.Size(138, 28);
            this.tbPrecioCompra.TabIndex = 26;
            this.tbPrecioCompra.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Precio Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Código del Producto:";
            // 
            // tbCodigoProducto
            // 
            this.tbCodigoProducto.Location = new System.Drawing.Point(251, 40);
            this.tbCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCodigoProducto.MaxLength = 31;
            this.tbCodigoProducto.Name = "tbCodigoProducto";
            this.tbCodigoProducto.ReadOnly = true;
            this.tbCodigoProducto.Size = new System.Drawing.Size(278, 28);
            this.tbCodigoProducto.TabIndex = 22;
            // 
            // cmbPresentaciones
            // 
            this.cmbPresentaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresentaciones.FormattingEnabled = true;
            this.cmbPresentaciones.Location = new System.Drawing.Point(271, 113);
            this.cmbPresentaciones.Name = "cmbPresentaciones";
            this.cmbPresentaciones.Size = new System.Drawing.Size(356, 32);
            this.cmbPresentaciones.TabIndex = 21;
            this.cmbPresentaciones.SelectedIndexChanged += new System.EventHandler(this.cmbPresentaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Presentacion/Unidades:";
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Location = new System.Drawing.Point(251, 6);
            this.tbNombreProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNombreProducto.MaxLength = 255;
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(491, 28);
            this.tbNombreProducto.TabIndex = 15;
            // 
            // cbGenerarCodigo
            // 
            this.cbGenerarCodigo.AutoSize = true;
            this.cbGenerarCodigo.Checked = true;
            this.cbGenerarCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGenerarCodigo.Location = new System.Drawing.Point(536, 42);
            this.cbGenerarCodigo.Name = "cbGenerarCodigo";
            this.cbGenerarCodigo.Size = new System.Drawing.Size(164, 28);
            this.cbGenerarCodigo.TabIndex = 32;
            this.cbGenerarCodigo.Text = "Auto-Generar";
            this.cbGenerarCodigo.UseVisualStyleBackColor = true;
            this.cbGenerarCodigo.CheckedChanged += new System.EventHandler(this.cbGenerarCodigo_CheckedChanged);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(13, 167);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 34;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bGuardar.Image = global::UI.Properties.Resources.guardar;
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGuardar.Location = new System.Drawing.Point(603, 167);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(139, 45);
            this.bGuardar.TabIndex = 33;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Bs.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Bs.";
            // 
            // FrmCompactProductoCrear
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 224);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cbGenerarCodigo);
            this.Controls.Add(this.bEditarPresentaciones);
            this.Controls.Add(this.tbPrecioVenta);
            this.Controls.Add(this.tbPrecioCompra);
            this.Controls.Add(this.tbNombreProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPresentaciones);
            this.Controls.Add(this.tbCodigoProducto);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCompactProductoCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.FrmCompactProductoCrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrecioCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bEditarPresentaciones;
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
        private CheckBox cbGenerarCodigo;
        private Button bCancelar;
        private Button bGuardar;
        private Label label5;
        private Label label7;
    }
}