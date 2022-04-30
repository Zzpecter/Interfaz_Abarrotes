namespace UI
{
    partial class FrmPerfil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCambiarPass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCambiarLogin = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblTiempoConexion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bEditarContactos = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.tmrTiempoConexion = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nivel:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(230, 46);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLogin.MaxLength = 127;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ReadOnly = true;
            this.tbLogin.Size = new System.Drawing.Size(278, 28);
            this.tbLogin.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bCambiarPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bCancelar);
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.bCambiarLogin);
            this.groupBox1.Controls.Add(this.lblNivel);
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 189);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Usuario";
            // 
            // bCambiarPass
            // 
            this.bCambiarPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCambiarPass.Image = global::UI.Properties.Resources.editar;
            this.bCambiarPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCambiarPass.Location = new System.Drawing.Point(516, 90);
            this.bCambiarPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCambiarPass.Name = "bCambiarPass";
            this.bCambiarPass.Size = new System.Drawing.Size(139, 45);
            this.bCambiarPass.TabIndex = 32;
            this.bCambiarPass.Text = "Cambiar";
            this.bCambiarPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCambiarPass.UseVisualStyleBackColor = false;
            this.bCambiarPass.Click += new System.EventHandler(this.bCambiarPass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "************";
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(810, 39);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 30;
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
            this.bGuardar.Location = new System.Drawing.Point(663, 39);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(139, 45);
            this.bGuardar.TabIndex = 29;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCambiarLogin
            // 
            this.bCambiarLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCambiarLogin.Image = global::UI.Properties.Resources.editar;
            this.bCambiarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCambiarLogin.Location = new System.Drawing.Point(516, 39);
            this.bCambiarLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCambiarLogin.Name = "bCambiarLogin";
            this.bCambiarLogin.Size = new System.Drawing.Size(139, 45);
            this.bCambiarLogin.TabIndex = 28;
            this.bCambiarLogin.Text = "Cambiar";
            this.bCambiarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCambiarLogin.UseVisualStyleBackColor = false;
            this.bCambiarLogin.Click += new System.EventHandler(this.bCambiarLogin_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(230, 149);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(65, 24);
            this.lblNivel.TabIndex = 27;
            this.lblNivel.Text = "Nivel";
            // 
            // lblTiempoConexion
            // 
            this.lblTiempoConexion.AutoSize = true;
            this.lblTiempoConexion.Location = new System.Drawing.Point(874, 392);
            this.lblTiempoConexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoConexion.Name = "lblTiempoConexion";
            this.lblTiempoConexion.Size = new System.Drawing.Size(98, 24);
            this.lblTiempoConexion.TabIndex = 29;
            this.lblTiempoConexion.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tiempo conectad@ al sistema:";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(12, 382);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 31;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bEditarContactos);
            this.groupBox2.Controls.Add(this.dgvContactos);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 169);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mi Info de Contacto:";
            // 
            // bEditarContactos
            // 
            this.bEditarContactos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bEditarContactos.Image = global::UI.Properties.Resources.editar;
            this.bEditarContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditarContactos.Location = new System.Drawing.Point(810, 109);
            this.bEditarContactos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEditarContactos.Name = "bEditarContactos";
            this.bEditarContactos.Size = new System.Drawing.Size(139, 45);
            this.bEditarContactos.TabIndex = 33;
            this.bEditarContactos.Text = "Editar";
            this.bEditarContactos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditarContactos.UseVisualStyleBackColor = false;
            this.bEditarContactos.Click += new System.EventHandler(this.bEditarContactos_Click);
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.AllowUserToResizeColumns = false;
            this.dgvContactos.AllowUserToResizeRows = false;
            this.dgvContactos.BackgroundColor = System.Drawing.Color.White;
            this.dgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactos.Location = new System.Drawing.Point(7, 27);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.RowHeadersVisible = false;
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.RowTemplate.Height = 29;
            this.dgvContactos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(772, 127);
            this.dgvContactos.TabIndex = 26;
            // 
            // tmrTiempoConexion
            // 
            this.tmrTiempoConexion.Interval = 1000;
            this.tmrTiempoConexion.Tick += new System.EventHandler(this.tmrTiempoConexion_Tick);
            // 
            // FrmPerfil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTiempoConexion);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Perfil";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label3;
        private TextBox tbLogin;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblNivel;
        private Label lblTiempoConexion;
        private Label label4;
        private Button bCancelar;
        private Button bCambiarLogin;
        private Button bCambiarPass;
        private Label label5;
        private Button bGuardar;
        private Button bVolver;
        private GroupBox groupBox2;
        private Button bEditarContactos;
        private DataGridView dgvContactos;
        private System.Windows.Forms.Timer tmrTiempoConexion;
    }
}