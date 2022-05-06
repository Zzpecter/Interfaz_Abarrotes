namespace UI
{
    partial class FrmCompactProveedorInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompactProveedorInsertar));
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bGuardar.Image = global::UI.Properties.Resources.guardar;
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGuardar.Location = new System.Drawing.Point(407, 76);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(139, 45);
            this.bGuardar.TabIndex = 54;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(11, 76);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 53;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(266, 12);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNombre.MaxLength = 127;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(280, 28);
            this.tbNombre.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nombre del Proveedor:";
            // 
            // FrmCompactProveedorInsertar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 147);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompactProveedorInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bGuardar;
        private Button bCancelar;
        private TextBox tbNombre;
        private Label label3;
    }
}