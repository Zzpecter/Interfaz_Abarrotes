namespace UI
{
    partial class FrmUnidadesPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnidadesPresentacion));
            this.bVolver = new System.Windows.Forms.Button();
            this.tbNombreMedida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.bElimiar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMultiplicadorKg = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMultiplicadorKg)).BeginInit();
            this.SuspendLayout();
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(13, 415);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 39;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // tbNombreMedida
            // 
            this.tbNombreMedida.Enabled = false;
            this.tbNombreMedida.Location = new System.Drawing.Point(251, 320);
            this.tbNombreMedida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNombreMedida.Name = "tbNombreMedida";
            this.tbNombreMedida.Size = new System.Drawing.Size(250, 28);
            this.tbNombreMedida.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre de la Medida:";
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(528, 259);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 37;
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
            this.bGuardar.Location = new System.Drawing.Point(528, 208);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(139, 45);
            this.bGuardar.TabIndex = 36;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AllowUserToAddRows = false;
            this.dgvUnidades.AllowUserToDeleteRows = false;
            this.dgvUnidades.AllowUserToResizeColumns = false;
            this.dgvUnidades.AllowUserToResizeRows = false;
            this.dgvUnidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUnidades.Location = new System.Drawing.Point(13, 12);
            this.dgvUnidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.RowHeadersVisible = false;
            this.dgvUnidades.RowHeadersWidth = 51;
            this.dgvUnidades.RowTemplate.Height = 29;
            this.dgvUnidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidades.Size = new System.Drawing.Size(488, 293);
            this.dgvUnidades.TabIndex = 38;
            this.dgvUnidades.SelectionChanged += new System.EventHandler(this.dgvUnidades_SelectionChanged);
            // 
            // bElimiar
            // 
            this.bElimiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bElimiar.Enabled = false;
            this.bElimiar.Image = global::UI.Properties.Resources.eliminar;
            this.bElimiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bElimiar.Location = new System.Drawing.Point(528, 111);
            this.bElimiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bElimiar.Name = "bElimiar";
            this.bElimiar.Size = new System.Drawing.Size(139, 45);
            this.bElimiar.TabIndex = 35;
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
            this.bActualizar.Location = new System.Drawing.Point(528, 60);
            this.bActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(139, 45);
            this.bActualizar.TabIndex = 34;
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
            this.bAgregar.Location = new System.Drawing.Point(528, 12);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(139, 45);
            this.bAgregar.TabIndex = 33;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Multiplicador a Kg.";
            // 
            // tbMultiplicadorKg
            // 
            this.tbMultiplicadorKg.DecimalPlaces = 2;
            this.tbMultiplicadorKg.Enabled = false;
            this.tbMultiplicadorKg.Location = new System.Drawing.Point(251, 367);
            this.tbMultiplicadorKg.Name = "tbMultiplicadorKg";
            this.tbMultiplicadorKg.Size = new System.Drawing.Size(150, 28);
            this.tbMultiplicadorKg.TabIndex = 42;
            this.tbMultiplicadorKg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmUnidadesPresentacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 468);
            this.Controls.Add(this.tbMultiplicadorKg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.tbNombreMedida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.dgvUnidades);
            this.Controls.Add(this.bElimiar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmUnidadesPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Unidades";
            this.Load += new System.EventHandler(this.FrmUnidadesPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMultiplicadorKg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bVolver;
        private TextBox tbNombreMedida;
        private Label label3;
        private Button bCancelar;
        private Button bGuardar;
        private DataGridView dgvUnidades;
        private Button bElimiar;
        private Button bActualizar;
        private Button bAgregar;
        private Label label1;
        private NumericUpDown tbMultiplicadorKg;
    }
}