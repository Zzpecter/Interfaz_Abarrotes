namespace UI
{
    partial class FrmCompactProductoBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompactProductoBuscar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bReestablecer = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bReestablecer);
            this.groupBox2.Controls.Add(this.tbBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvDatos);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 385);
            this.groupBox2.TabIndex = 31;
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
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(169, 44);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(545, 28);
            this.tbBuscar.TabIndex = 26;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            this.tbBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBuscar_KeyUp);
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
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(12, 403);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 33;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bSeleccionar.Image = global::UI.Properties.Resources.agregar;
            this.bSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSeleccionar.Location = new System.Drawing.Point(768, 403);
            this.bSeleccionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(179, 45);
            this.bSeleccionar.TabIndex = 32;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSeleccionar.UseVisualStyleBackColor = false;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // FrmCompactProductoBuscar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 466);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bSeleccionar);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCompactProductoBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Productos";
            this.Load += new System.EventHandler(this.FrmCompactProductoBuscar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Button bReestablecer;
        private TextBox tbBuscar;
        private Label label5;
        private DataGridView dgvDatos;
        private Button bCancelar;
        private Button bSeleccionar;
    }
}