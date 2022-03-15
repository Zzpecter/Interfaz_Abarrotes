namespace UI
{
    partial class FrmCliente
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
            this.tbNombreRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.bElimiar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.tbNitCi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombreRazonSocial
            // 
            this.tbNombreRazonSocial.Enabled = false;
            this.tbNombreRazonSocial.Location = new System.Drawing.Point(219, 340);
            this.tbNombreRazonSocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNombreRazonSocial.Name = "tbNombreRazonSocial";
            this.tbNombreRazonSocial.Size = new System.Drawing.Size(296, 23);
            this.tbNombreRazonSocial.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre/Razon social:";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(602, 322);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 14;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(602, 271);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 13;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click_1);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bGuardar.Image = global::UI.Properties.Resources.guardar;
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGuardar.Location = new System.Drawing.Point(602, 220);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(139, 45);
            this.bGuardar.TabIndex = 12;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click_1);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCliente.Location = new System.Drawing.Point(34, 24);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 29;
            this.dgvCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(481, 293);
            this.dgvCliente.TabIndex = 16;
            this.dgvCliente.SelectionChanged += new System.EventHandler(this.dgvCliente_SelectionChanged_1);
            // 
            // bElimiar
            // 
            this.bElimiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bElimiar.Enabled = false;
            this.bElimiar.Image = global::UI.Properties.Resources.eliminar;
            this.bElimiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bElimiar.Location = new System.Drawing.Point(602, 123);
            this.bElimiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bElimiar.Name = "bElimiar";
            this.bElimiar.Size = new System.Drawing.Size(139, 45);
            this.bElimiar.TabIndex = 11;
            this.bElimiar.Text = "Eliminar";
            this.bElimiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bElimiar.UseVisualStyleBackColor = false;
            this.bElimiar.Click += new System.EventHandler(this.bElimiar_Click_1);
            // 
            // bActualizar
            // 
            this.bActualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bActualizar.Enabled = false;
            this.bActualizar.Image = global::UI.Properties.Resources.editar;
            this.bActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bActualizar.Location = new System.Drawing.Point(602, 72);
            this.bActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(139, 45);
            this.bActualizar.TabIndex = 10;
            this.bActualizar.Text = "Editar";
            this.bActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bActualizar.UseVisualStyleBackColor = false;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click_1);
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAgregar.Image = global::UI.Properties.Resources.agregar;
            this.bAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAgregar.Location = new System.Drawing.Point(602, 24);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(139, 45);
            this.bAgregar.TabIndex = 9;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click_1);
            // 
            // tbNitCi
            // 
            this.tbNitCi.Enabled = false;
            this.tbNitCi.Location = new System.Drawing.Point(218, 390);
            this.tbNitCi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNitCi.Name = "tbNitCi";
            this.tbNitCi.Size = new System.Drawing.Size(296, 23);
            this.tbNitCi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nit/Ci:";
            // 
            // FrmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNitCi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.bElimiar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNombreRazonSocial;
        private Label label1;
        private Button bVolver;
        private Button bCancelar;
        private Button bGuardar;
        private DataGridView dgvCliente;
        private Button bElimiar;
        private Button bActualizar;
        private Button bAgregar;
        private TextBox tbNitCi;
        private Label label2;
    }
}