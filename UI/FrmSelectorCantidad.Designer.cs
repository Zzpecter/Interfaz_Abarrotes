namespace UI
{
    partial class FrmSelectorCantidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectorCantidad));
            this.tbCantidad = new System.Windows.Forms.NumericUpDown();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(147, 49);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(274, 46);
            this.tbCantidad.TabIndex = 0;
            this.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(13, 101);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(224, 84);
            this.bCancelar.TabIndex = 34;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAceptar.Image = global::UI.Properties.Resources.agregar;
            this.bAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAceptar.Location = new System.Drawing.Point(348, 101);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(210, 84);
            this.bAceptar.TabIndex = 35;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cantidad:";
            // 
            // FrmSelectorCantidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.tbCantidad);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectorCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selector de Cantidad";
            this.Load += new System.EventHandler(this.FrmSelectorCantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown tbCantidad;
        private Button bCancelar;
        private Button bAceptar;
        private Label label1;
    }
}