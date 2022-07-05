namespace UI
{
    partial class FrmListadoReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoReportes));
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.bImprimir = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.AllowUserToResizeColumns = false;
            this.dgvReportes.AllowUserToResizeRows = false;
            this.dgvReportes.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReportes.Location = new System.Drawing.Point(13, 12);
            this.dgvReportes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersVisible = false;
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 29;
            this.dgvReportes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(734, 313);
            this.dgvReportes.TabIndex = 37;
            this.dgvReportes.SelectionChanged += new System.EventHandler(this.dgvReportes_SelectionChanged);
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bImprimir.Enabled = false;
            this.bImprimir.Image = global::UI.Properties.Resources.editar;
            this.bImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bImprimir.Location = new System.Drawing.Point(596, 353);
            this.bImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(151, 45);
            this.bImprimir.TabIndex = 46;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bImprimir.UseVisualStyleBackColor = false;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(13, 353);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 45;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bAbrir
            // 
            this.bAbrir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAbrir.Enabled = false;
            this.bAbrir.Image = global::UI.Properties.Resources.editar;
            this.bAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAbrir.Location = new System.Drawing.Point(275, 353);
            this.bAbrir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAbrir.Name = "bAbrir";
            this.bAbrir.Size = new System.Drawing.Size(133, 45);
            this.bAbrir.TabIndex = 47;
            this.bAbrir.Text = "Abrir";
            this.bAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAbrir.UseVisualStyleBackColor = false;
            this.bAbrir.Click += new System.EventHandler(this.bAbrir_Click);
            // 
            // FrmListadoReportes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 406);
            this.Controls.Add(this.bAbrir);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.dgvReportes);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmListadoReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Reportes";
            this.Load += new System.EventHandler(this.FrmListadoReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvReportes;
        private Button bImprimir;
        private Button bVolver;
        private Button bAbrir;
    }
}