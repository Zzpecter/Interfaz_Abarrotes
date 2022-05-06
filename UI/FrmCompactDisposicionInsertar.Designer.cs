namespace UI
{
    partial class FrmCompactDisposicionInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompactDisposicionInsertar));
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigoProducto = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tbUnidades = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPresentacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbInfoDisposicion = new System.Windows.Forms.GroupBox();
            this.tbComentario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bEditarMotivos = new System.Windows.Forms.Button();
            this.cbEliminarStock = new System.Windows.Forms.CheckBox();
            this.cmbMotivos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbInfoDisposicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(12, 455);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 50;
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
            this.bGuardar.Location = new System.Drawing.Point(591, 455);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(139, 45);
            this.bGuardar.TabIndex = 49;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Location = new System.Drawing.Point(249, 37);
            this.tbNombreProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNombreProducto.MaxLength = 255;
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.ReadOnly = true;
            this.tbNombreProducto.Size = new System.Drawing.Size(278, 28);
            this.tbNombreProducto.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre del Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Código del Producto:";
            // 
            // tbCodigoProducto
            // 
            this.tbCodigoProducto.Location = new System.Drawing.Point(249, 71);
            this.tbCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCodigoProducto.MaxLength = 31;
            this.tbCodigoProducto.Name = "tbCodigoProducto";
            this.tbCodigoProducto.ReadOnly = true;
            this.tbCodigoProducto.Size = new System.Drawing.Size(278, 28);
            this.tbCodigoProducto.TabIndex = 41;
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bBuscar.Image = global::UI.Properties.Resources.search1;
            this.bBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscar.Location = new System.Drawing.Point(535, 36);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(155, 62);
            this.bBuscar.TabIndex = 51;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tbUnidades
            // 
            this.tbUnidades.Location = new System.Drawing.Point(249, 139);
            this.tbUnidades.Name = "tbUnidades";
            this.tbUnidades.ReadOnly = true;
            this.tbUnidades.Size = new System.Drawing.Size(278, 28);
            this.tbUnidades.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "Unidades:";
            // 
            // tbPresentacion
            // 
            this.tbPresentacion.Location = new System.Drawing.Point(249, 105);
            this.tbPresentacion.Name = "tbPresentacion";
            this.tbPresentacion.ReadOnly = true;
            this.tbPresentacion.Size = new System.Drawing.Size(278, 28);
            this.tbPresentacion.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "Presentacion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBuscar);
            this.groupBox1.Controls.Add(this.tbUnidades);
            this.groupBox1.Controls.Add(this.tbCodigoProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPresentacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNombreProducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 180);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info del Producto";
            // 
            // gbInfoDisposicion
            // 
            this.gbInfoDisposicion.Controls.Add(this.tbComentario);
            this.gbInfoDisposicion.Controls.Add(this.label7);
            this.gbInfoDisposicion.Controls.Add(this.bEditarMotivos);
            this.gbInfoDisposicion.Controls.Add(this.cbEliminarStock);
            this.gbInfoDisposicion.Controls.Add(this.cmbMotivos);
            this.gbInfoDisposicion.Controls.Add(this.label6);
            this.gbInfoDisposicion.Controls.Add(this.tbCantidad);
            this.gbInfoDisposicion.Controls.Add(this.label3);
            this.gbInfoDisposicion.Enabled = false;
            this.gbInfoDisposicion.Location = new System.Drawing.Point(12, 198);
            this.gbInfoDisposicion.Name = "gbInfoDisposicion";
            this.gbInfoDisposicion.Size = new System.Drawing.Size(718, 251);
            this.gbInfoDisposicion.TabIndex = 57;
            this.gbInfoDisposicion.TabStop = false;
            this.gbInfoDisposicion.Text = "Info de la Disposicion";
            // 
            // tbComentario
            // 
            this.tbComentario.Location = new System.Drawing.Point(246, 112);
            this.tbComentario.Multiline = true;
            this.tbComentario.Name = "tbComentario";
            this.tbComentario.ReadOnly = true;
            this.tbComentario.Size = new System.Drawing.Size(444, 124);
            this.tbComentario.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 56;
            this.label7.Text = "Comentario:";
            // 
            // bEditarMotivos
            // 
            this.bEditarMotivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bEditarMotivos.Image = global::UI.Properties.Resources.editar_small;
            this.bEditarMotivos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditarMotivos.Location = new System.Drawing.Point(561, 73);
            this.bEditarMotivos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEditarMotivos.Name = "bEditarMotivos";
            this.bEditarMotivos.Size = new System.Drawing.Size(104, 32);
            this.bEditarMotivos.TabIndex = 58;
            this.bEditarMotivos.Text = "Editar";
            this.bEditarMotivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditarMotivos.UseVisualStyleBackColor = false;
            // 
            // cbEliminarStock
            // 
            this.cbEliminarStock.AutoSize = true;
            this.cbEliminarStock.Location = new System.Drawing.Point(380, 39);
            this.cbEliminarStock.Name = "cbEliminarStock";
            this.cbEliminarStock.Size = new System.Drawing.Size(285, 28);
            this.cbEliminarStock.TabIndex = 2;
            this.cbEliminarStock.Text = "Disponer Stock Completo";
            this.cbEliminarStock.UseVisualStyleBackColor = true;
            this.cbEliminarStock.CheckedChanged += new System.EventHandler(this.cbEliminarStock_CheckedChanged);
            // 
            // cmbMotivos
            // 
            this.cmbMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivos.FormattingEnabled = true;
            this.cmbMotivos.Location = new System.Drawing.Point(246, 74);
            this.cmbMotivos.Name = "cmbMotivos";
            this.cmbMotivos.Size = new System.Drawing.Size(308, 32);
            this.cmbMotivos.TabIndex = 60;
            this.cmbMotivos.SelectedIndexChanged += new System.EventHandler(this.cmbMotivos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Motivo:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.DecimalPlaces = 2;
            this.tbCantidad.Location = new System.Drawing.Point(246, 39);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(114, 28);
            this.tbCantidad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad:";
            // 
            // FrmCompactDisposicionInsertar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 511);
            this.Controls.Add(this.gbInfoDisposicion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCompactDisposicionInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Disposicion";
            this.Load += new System.EventHandler(this.FrmCompactDisposicionInsertar_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCompactDisposicionInsertar_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbInfoDisposicion.ResumeLayout(false);
            this.gbInfoDisposicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bCancelar;
        private Button bGuardar;
        private TextBox tbNombreProducto;
        private Label label1;
        private Label label2;
        private TextBox tbCodigoProducto;
        private Button bBuscar;
        private TextBox tbUnidades;
        private Label label5;
        private TextBox tbPresentacion;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox gbInfoDisposicion;
        private CheckBox cbEliminarStock;
        private NumericUpDown tbCantidad;
        private Label label3;
        private TextBox tbComentario;
        private Label label7;
        private Button bEditarMotivos;
        private ComboBox cmbMotivos;
        private Label label6;
    }
}