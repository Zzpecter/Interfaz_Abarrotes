namespace UI
{
    partial class FrmCambiarPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarPass));
            this.tbPasswordAntiguo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPasswordNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordNuevo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lblCoincidencia = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPasswordAntiguo
            // 
            this.tbPasswordAntiguo.Location = new System.Drawing.Point(379, 58);
            this.tbPasswordAntiguo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPasswordAntiguo.MaxLength = 255;
            this.tbPasswordAntiguo.Name = "tbPasswordAntiguo";
            this.tbPasswordAntiguo.PasswordChar = '*';
            this.tbPasswordAntiguo.Size = new System.Drawing.Size(534, 42);
            this.tbPasswordAntiguo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contraseña Antigua:";
            // 
            // tbPasswordNuevo
            // 
            this.tbPasswordNuevo.Location = new System.Drawing.Point(379, 141);
            this.tbPasswordNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPasswordNuevo.MaxLength = 255;
            this.tbPasswordNuevo.Name = "tbPasswordNuevo";
            this.tbPasswordNuevo.PasswordChar = '*';
            this.tbPasswordNuevo.Size = new System.Drawing.Size(534, 42);
            this.tbPasswordNuevo.TabIndex = 23;
            this.tbPasswordNuevo.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPasswordNuevo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPasswordNuevo_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Contraseña Nueva:";
            // 
            // tbPasswordNuevo2
            // 
            this.tbPasswordNuevo2.Location = new System.Drawing.Point(379, 201);
            this.tbPasswordNuevo2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPasswordNuevo2.MaxLength = 255;
            this.tbPasswordNuevo2.Name = "tbPasswordNuevo2";
            this.tbPasswordNuevo2.PasswordChar = '*';
            this.tbPasswordNuevo2.Size = new System.Drawing.Size(534, 42);
            this.tbPasswordNuevo2.TabIndex = 25;
            this.tbPasswordNuevo2.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 80);
            this.label3.TabIndex = 24;
            this.label3.Text = "Repita la \r\nContraseña Nueva:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(13, 392);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(207, 64);
            this.bCancelar.TabIndex = 32;
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
            this.bGuardar.Location = new System.Drawing.Point(782, 392);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(182, 64);
            this.bGuardar.TabIndex = 31;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(237, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 60);
            this.label4.TabIndex = 33;
            this.label4.Text = "Importante:\r\nLa contraseña debe tener al menos 4 caracteres y al menos \r\nuna mayú" +
    "scula o dígito.\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPasswordNuevo2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPasswordAntiguo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPasswordNuevo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 286);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Requerida";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 301);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(449, 40);
            this.lb1.TabIndex = 26;
            this.lb1.Text = "Fuerza de la Contraseña:";
            // 
            // lblCoincidencia
            // 
            this.lblCoincidencia.AutoSize = true;
            this.lblCoincidencia.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCoincidencia.ForeColor = System.Drawing.Color.Red;
            this.lblCoincidencia.Location = new System.Drawing.Point(635, 365);
            this.lblCoincidencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoincidencia.Name = "lblCoincidencia";
            this.lblCoincidencia.Size = new System.Drawing.Size(329, 24);
            this.lblCoincidencia.TabIndex = 35;
            this.lblCoincidencia.Text = "Las contraseñas no coinciden!";
            this.lblCoincidencia.Visible = false;
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(469, 301);
            this.lblFuerza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(197, 40);
            this.lblFuerza.TabIndex = 36;
            this.lblFuerza.Text = "=> Ninguna";
            // 
            // FrmCambiarPass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 472);
            this.Controls.Add(this.lblFuerza);
            this.Controls.Add(this.lblCoincidencia);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Contraseña";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbPasswordAntiguo;
        private Label label2;
        private TextBox tbPasswordNuevo;
        private Label label1;
        private TextBox tbPasswordNuevo2;
        private Label label3;
        private Button bCancelar;
        private Button bGuardar;
        private Label label4;
        private GroupBox groupBox1;
        private Label lb1;
        private Label lblCoincidencia;
        private Label lblFuerza;
    }
}