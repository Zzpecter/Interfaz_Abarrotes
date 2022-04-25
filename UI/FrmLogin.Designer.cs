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
            this.bActualizar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // bActualizar
            // 
            this.bActualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bActualizar.Enabled = false;
            this.bActualizar.Image = global::UI.Properties.Resources.enter;
            this.bActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bActualizar.Location = new System.Drawing.Point(609, 396);
            this.bActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(192, 69);
            this.bActualizar.TabIndex = 58;
            this.bActualizar.Text = "Acceder";
            this.bActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bActualizar.UseVisualStyleBackColor = false;
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bSalir.Enabled = false;
            this.bSalir.Image = global::UI.Properties.Resources.exit;
            this.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSalir.Location = new System.Drawing.Point(13, 396);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(192, 69);
            this.bSalir.TabIndex = 59;
            this.bSalir.Text = "Salir";
            this.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalir.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 215);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbIP);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 154);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado de API";
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
            this.tbIP.Enabled = false;
            this.tbIP.Location = new System.Drawing.Point(6, 108);
            this.tbIP.Name = "tbIP";
            this.tbIP.ReadOnly = true;
            this.tbIP.Size = new System.Drawing.Size(522, 39);
            this.tbIP.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(813, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bActualizar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Button bActualizar;
        private Button bSalir;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox tbIP;
    }
}