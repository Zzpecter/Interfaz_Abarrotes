namespace UI
{
    partial class FrmDisposiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisposiciones));
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDisposiciones = new System.Windows.Forms.DataGridView();
            this.bNuevaDisposicion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisposiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(12, 381);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 42;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDisposiciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 363);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado";
            // 
            // dgvDisposiciones
            // 
            this.dgvDisposiciones.AllowUserToAddRows = false;
            this.dgvDisposiciones.AllowUserToDeleteRows = false;
            this.dgvDisposiciones.AllowUserToResizeColumns = false;
            this.dgvDisposiciones.AllowUserToResizeRows = false;
            this.dgvDisposiciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisposiciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisposiciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvDisposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisposiciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDisposiciones.Location = new System.Drawing.Point(7, 27);
            this.dgvDisposiciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDisposiciones.Name = "dgvDisposiciones";
            this.dgvDisposiciones.RowHeadersVisible = false;
            this.dgvDisposiciones.RowHeadersWidth = 51;
            this.dgvDisposiciones.RowTemplate.Height = 29;
            this.dgvDisposiciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDisposiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisposiciones.Size = new System.Drawing.Size(1109, 326);
            this.dgvDisposiciones.TabIndex = 36;
            // 
            // bNuevaDisposicion
            // 
            this.bNuevaDisposicion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bNuevaDisposicion.Image = global::UI.Properties.Resources.agregar;
            this.bNuevaDisposicion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNuevaDisposicion.Location = new System.Drawing.Point(890, 381);
            this.bNuevaDisposicion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bNuevaDisposicion.Name = "bNuevaDisposicion";
            this.bNuevaDisposicion.Size = new System.Drawing.Size(245, 45);
            this.bNuevaDisposicion.TabIndex = 44;
            this.bNuevaDisposicion.Text = "Nueva Disposicion";
            this.bNuevaDisposicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNuevaDisposicion.UseVisualStyleBackColor = false;
            this.bNuevaDisposicion.Click += new System.EventHandler(this.bNuevaDisposicion_Click);
            // 
            // FrmDisposiciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 438);
            this.Controls.Add(this.bNuevaDisposicion);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDisposiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Disposiciones";
            this.Load += new System.EventHandler(this.FrmDisposiciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisposiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button bVolver;
        private GroupBox groupBox1;
        private DataGridView dgvDisposiciones;
        private Button bNuevaDisposicion;
    }
}