namespace UI
{
    partial class FrmGeneradorReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneradorReportes));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bReporteAnualPasado = new System.Windows.Forms.Button();
            this.bReporteSemanalPasada = new System.Windows.Forms.Button();
            this.bReporteDiarioAyer = new System.Windows.Forms.Button();
            this.bReporteAnualActual = new System.Windows.Forms.Button();
            this.bReporteSemanalActual = new System.Windows.Forms.Button();
            this.bReporteDiarioHoy = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.rbPredeterminados = new System.Windows.Forms.RadioButton();
            this.rbFiltrarFecha = new System.Windows.Forms.RadioButton();
            this.bGenerar = new System.Windows.Forms.Button();
            this.bReporteCompras = new System.Windows.Forms.Button();
            this.bReporteVentas = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHasta);
            this.groupBox2.Controls.Add(this.lblDesde);
            this.groupBox2.Controls.Add(this.lblProducto);
            this.groupBox2.Controls.Add(this.bBuscar);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.bReporteAnualPasado);
            this.groupBox2.Controls.Add(this.bReporteSemanalPasada);
            this.groupBox2.Controls.Add(this.bReporteDiarioAyer);
            this.groupBox2.Controls.Add(this.bReporteAnualActual);
            this.groupBox2.Controls.Add(this.bReporteSemanalActual);
            this.groupBox2.Controls.Add(this.bReporteDiarioHoy);
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Controls.Add(this.rbPredeterminados);
            this.groupBox2.Controls.Add(this.rbFiltrarFecha);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 170);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(489, 95);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(76, 24);
            this.lblHasta.TabIndex = 51;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(489, 61);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(76, 24);
            this.lblDesde.TabIndex = 50;
            this.lblDesde.Text = "Desde:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(783, 111);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(230, 24);
            this.lblProducto.TabIndex = 49;
            this.lblProducto.Text = "Ninguno Seleccionado";
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bBuscar.Image = global::UI.Properties.Resources.search1;
            this.bBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscar.Location = new System.Drawing.Point(818, 61);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(137, 47);
            this.bBuscar.TabIndex = 44;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscar.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(769, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(263, 28);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Filtrar por Producto:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bReporteAnualPasado
            // 
            this.bReporteAnualPasado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReporteAnualPasado.Enabled = false;
            this.bReporteAnualPasado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReporteAnualPasado.Location = new System.Drawing.Point(202, 125);
            this.bReporteAnualPasado.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.bReporteAnualPasado.Name = "bReporteAnualPasado";
            this.bReporteAnualPasado.Size = new System.Drawing.Size(196, 34);
            this.bReporteAnualPasado.TabIndex = 47;
            this.bReporteAnualPasado.Text = "Anual (Pasado)";
            this.bReporteAnualPasado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReporteAnualPasado.UseVisualStyleBackColor = false;
            // 
            // bReporteSemanalPasada
            // 
            this.bReporteSemanalPasada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReporteSemanalPasada.Enabled = false;
            this.bReporteSemanalPasada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReporteSemanalPasada.Location = new System.Drawing.Point(227, 92);
            this.bReporteSemanalPasada.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.bReporteSemanalPasada.Name = "bReporteSemanalPasada";
            this.bReporteSemanalPasada.Size = new System.Drawing.Size(227, 34);
            this.bReporteSemanalPasada.TabIndex = 46;
            this.bReporteSemanalPasada.Text = "Semanal (Pasada)";
            this.bReporteSemanalPasada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReporteSemanalPasada.UseVisualStyleBackColor = false;
            // 
            // bReporteDiarioAyer
            // 
            this.bReporteDiarioAyer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReporteDiarioAyer.Enabled = false;
            this.bReporteDiarioAyer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReporteDiarioAyer.Location = new System.Drawing.Point(174, 61);
            this.bReporteDiarioAyer.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.bReporteDiarioAyer.Name = "bReporteDiarioAyer";
            this.bReporteDiarioAyer.Size = new System.Drawing.Size(169, 34);
            this.bReporteDiarioAyer.TabIndex = 45;
            this.bReporteDiarioAyer.Text = "Diario (Ayer)";
            this.bReporteDiarioAyer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReporteDiarioAyer.UseVisualStyleBackColor = false;
            // 
            // bReporteAnualActual
            // 
            this.bReporteAnualActual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReporteAnualActual.Enabled = false;
            this.bReporteAnualActual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReporteAnualActual.Location = new System.Drawing.Point(7, 125);
            this.bReporteAnualActual.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.bReporteAnualActual.Name = "bReporteAnualActual";
            this.bReporteAnualActual.Size = new System.Drawing.Size(196, 34);
            this.bReporteAnualActual.TabIndex = 42;
            this.bReporteAnualActual.Text = "Anual (Actual)";
            this.bReporteAnualActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReporteAnualActual.UseVisualStyleBackColor = false;
            // 
            // bReporteSemanalActual
            // 
            this.bReporteSemanalActual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReporteSemanalActual.Enabled = false;
            this.bReporteSemanalActual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReporteSemanalActual.Location = new System.Drawing.Point(6, 92);
            this.bReporteSemanalActual.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.bReporteSemanalActual.Name = "bReporteSemanalActual";
            this.bReporteSemanalActual.Size = new System.Drawing.Size(227, 34);
            this.bReporteSemanalActual.TabIndex = 44;
            this.bReporteSemanalActual.Text = "Semanal (Actual)";
            this.bReporteSemanalActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReporteSemanalActual.UseVisualStyleBackColor = false;
            // 
            // bReporteDiarioHoy
            // 
            this.bReporteDiarioHoy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bReporteDiarioHoy.Enabled = false;
            this.bReporteDiarioHoy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReporteDiarioHoy.Location = new System.Drawing.Point(6, 61);
            this.bReporteDiarioHoy.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.bReporteDiarioHoy.Name = "bReporteDiarioHoy";
            this.bReporteDiarioHoy.Size = new System.Drawing.Size(169, 34);
            this.bReporteDiarioHoy.TabIndex = 41;
            this.bReporteDiarioHoy.Text = "Diario (Hoy)";
            this.bReporteDiarioHoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReporteDiarioHoy.UseVisualStyleBackColor = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(571, 95);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(155, 28);
            this.dtpHasta.TabIndex = 6;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(571, 61);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(155, 28);
            this.dtpDesde.TabIndex = 4;
            // 
            // rbPredeterminados
            // 
            this.rbPredeterminados.AutoSize = true;
            this.rbPredeterminados.Location = new System.Drawing.Point(7, 27);
            this.rbPredeterminados.Name = "rbPredeterminados";
            this.rbPredeterminados.Size = new System.Drawing.Size(196, 28);
            this.rbPredeterminados.TabIndex = 1;
            this.rbPredeterminados.TabStop = true;
            this.rbPredeterminados.Text = "Predeterminados";
            this.rbPredeterminados.UseVisualStyleBackColor = true;
            // 
            // rbFiltrarFecha
            // 
            this.rbFiltrarFecha.AutoSize = true;
            this.rbFiltrarFecha.Location = new System.Drawing.Point(467, 27);
            this.rbFiltrarFecha.Name = "rbFiltrarFecha";
            this.rbFiltrarFecha.Size = new System.Drawing.Size(218, 28);
            this.rbFiltrarFecha.TabIndex = 0;
            this.rbFiltrarFecha.TabStop = true;
            this.rbFiltrarFecha.Text = "Filtrar por Fecha";
            this.rbFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // bGenerar
            // 
            this.bGenerar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGenerar.Location = new System.Drawing.Point(917, 293);
            this.bGenerar.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(138, 34);
            this.bGenerar.TabIndex = 43;
            this.bGenerar.Text = "Generar!";
            this.bGenerar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bGenerar.UseVisualStyleBackColor = false;
            this.bGenerar.Click += new System.EventHandler(this.bGenerar_Click);
            // 
            // bReporteCompras
            // 
            this.bReporteCompras.Image = global::UI.Properties.Resources.buy;
            this.bReporteCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReporteCompras.Location = new System.Drawing.Point(261, 2);
            this.bReporteCompras.Name = "bReporteCompras";
            this.bReporteCompras.Size = new System.Drawing.Size(246, 111);
            this.bReporteCompras.TabIndex = 45;
            this.bReporteCompras.Text = "Reporte Compras";
            this.bReporteCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReporteCompras.UseVisualStyleBackColor = true;
            // 
            // bReporteVentas
            // 
            this.bReporteVentas.Image = global::UI.Properties.Resources.sell;
            this.bReporteVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReporteVentas.Location = new System.Drawing.Point(12, 2);
            this.bReporteVentas.Name = "bReporteVentas";
            this.bReporteVentas.Size = new System.Drawing.Size(243, 111);
            this.bReporteVentas.TabIndex = 44;
            this.bReporteVentas.Text = "Reporte Ventas";
            this.bReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReporteVentas.UseVisualStyleBackColor = true;
            // 
            // FrmGeneradorReportes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 338);
            this.Controls.Add(this.bReporteCompras);
            this.Controls.Add(this.bReporteVentas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bGenerar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeneradorReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private RadioButton rbPredeterminados;
        private RadioButton rbFiltrarFecha;
        private CheckBox checkBox1;
        private Button bReporteAnualPasado;
        private Button bReporteSemanalPasada;
        private Button bReporteDiarioAyer;
        private Button bReporteAnualActual;
        private Button bReporteSemanalActual;
        private Button bReporteDiarioHoy;
        private Button bGenerar;
        private Label lblHasta;
        private Label lblDesde;
        private Label lblProducto;
        private Button bBuscar;
        private Button bReporteCompras;
        private Button bReporteVentas;
    }
}