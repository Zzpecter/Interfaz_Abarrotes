namespace UI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bAcceder = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbEstado = new System.Windows.Forms.PictureBox();
            this.bActualizarConexion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(311, 54);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(458, 39);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(311, 121);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(458, 39);
            this.tbPassword.TabIndex = 3;
            // 
            // bAcceder
            // 
            this.bAcceder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAcceder.Enabled = false;
            this.bAcceder.Image = global::UI.Properties.Resources.enter;
            this.bAcceder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAcceder.Location = new System.Drawing.Point(608, 428);
            this.bAcceder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAcceder.Name = "bAcceder";
            this.bAcceder.Size = new System.Drawing.Size(192, 69);
            this.bAcceder.TabIndex = 58;
            this.bAcceder.Text = "Acceder";
            this.bAcceder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAcceder.UseVisualStyleBackColor = false;
            this.bAcceder.Click += new System.EventHandler(this.bAcceder_Click);
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bSalir.Image = global::UI.Properties.Resources.exit;
            this.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSalir.Location = new System.Drawing.Point(13, 428);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(192, 69);
            this.bSalir.TabIndex = 59;
            this.bSalir.Text = "Salir";
            this.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 215);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbEstado);
            this.groupBox2.Controls.Add(this.bActualizarConexion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbIP);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 154);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado de API";
            // 
            // pbEstado
            // 
            this.pbEstado.Image = global::UI.Properties.Resources.icon_notok;
            this.pbEstado.Location = new System.Drawing.Point(641, 65);
            this.pbEstado.Name = "pbEstado";
            this.pbEstado.Size = new System.Drawing.Size(82, 82);
            this.pbEstado.TabIndex = 63;
            this.pbEstado.TabStop = false;
            // 
            // bActualizarConexion
            // 
            this.bActualizarConexion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bActualizarConexion.Enabled = false;
            this.bActualizarConexion.Image = global::UI.Properties.Resources.refresh;
            this.bActualizarConexion.Location = new System.Drawing.Point(535, 108);
            this.bActualizarConexion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bActualizarConexion.Name = "bActualizarConexion";
            this.bActualizarConexion.Size = new System.Drawing.Size(40, 40);
            this.bActualizarConexion.TabIndex = 62;
            this.bActualizarConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bActualizarConexion.UseVisualStyleBackColor = false;
            this.bActualizarConexion.Click += new System.EventHandler(this.bActualizarConexion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Direccion IP:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(6, 108);
            this.tbIP.Name = "tbIP";
            this.tbIP.ReadOnly = true;
            this.tbIP.Size = new System.Drawing.Size(522, 39);
            this.tbIP.TabIndex = 0;
            this.tbIP.DoubleClick += new System.EventHandler(this.tbIP_DoubleClick);
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bAcceder);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticación";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Button bAcceder;
        private Button bSalir;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox tbIP;
        private PictureBox pbEstado;
        private Button bActualizarConexion;
        private Label label4;
    }
}