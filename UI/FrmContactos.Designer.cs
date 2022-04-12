namespace UI
{
    partial class FrmContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContactos));
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.tbCorreoCodigoCalle = new System.Windows.Forms.TextBox();
            this.lblCorreoCodigoCalle = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.bElimiar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDetalles = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.tbZona = new System.Windows.Forms.TextBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.tbNumeros = new System.Windows.Forms.TextBox();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTelefono = new System.Windows.Forms.RadioButton();
            this.rbDireccion = new System.Windows.Forms.RadioButton();
            this.rbCorreo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(622, 27);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(383, 32);
            this.cmbLocalidades.TabIndex = 64;
            this.cmbLocalidades.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidades_SelectedIndexChanged);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(495, 30);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(120, 24);
            this.lblLocalidad.TabIndex = 63;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVolver.Image = global::UI.Properties.Resources.volver;
            this.bVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVolver.Location = new System.Drawing.Point(12, 597);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 45);
            this.bVolver.TabIndex = 62;
            this.bVolver.Text = "Volver";
            this.bVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVolver.UseVisualStyleBackColor = false;
            // 
            // tbCorreoCodigoCalle
            // 
            this.tbCorreoCodigoCalle.Enabled = false;
            this.tbCorreoCodigoCalle.Location = new System.Drawing.Point(175, 69);
            this.tbCorreoCodigoCalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCorreoCodigoCalle.Name = "tbCorreoCodigoCalle";
            this.tbCorreoCodigoCalle.Size = new System.Drawing.Size(316, 28);
            this.tbCorreoCodigoCalle.TabIndex = 54;
            // 
            // lblCorreoCodigoCalle
            // 
            this.lblCorreoCodigoCalle.AutoSize = true;
            this.lblCorreoCodigoCalle.Location = new System.Drawing.Point(15, 72);
            this.lblCorreoCodigoCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoCodigoCalle.Name = "lblCorreoCodigoCalle";
            this.lblCorreoCodigoCalle.Size = new System.Drawing.Size(76, 24);
            this.lblCorreoCodigoCalle.TabIndex = 55;
            this.lblCorreoCodigoCalle.Text = "Calle:";
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bCancelar.Image = global::UI.Properties.Resources.cancelar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.Location = new System.Drawing.Point(1063, 535);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(139, 45);
            this.bCancelar.TabIndex = 60;
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
            this.bGuardar.Location = new System.Drawing.Point(1063, 484);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(139, 45);
            this.bGuardar.TabIndex = 59;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
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
            this.dgvContactos.Location = new System.Drawing.Point(12, 99);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersVisible = false;
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.RowTemplate.Height = 29;
            this.dgvContactos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(1043, 230);
            this.dgvContactos.TabIndex = 61;
            this.dgvContactos.SelectionChanged += new System.EventHandler(this.dgvContactos_SelectionChanged);
            // 
            // bElimiar
            // 
            this.bElimiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bElimiar.Enabled = false;
            this.bElimiar.Image = global::UI.Properties.Resources.eliminar;
            this.bElimiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bElimiar.Location = new System.Drawing.Point(1063, 198);
            this.bElimiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bElimiar.Name = "bElimiar";
            this.bElimiar.Size = new System.Drawing.Size(139, 45);
            this.bElimiar.TabIndex = 58;
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
            this.bActualizar.Location = new System.Drawing.Point(1063, 147);
            this.bActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(139, 45);
            this.bActualizar.TabIndex = 57;
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
            this.bAgregar.Location = new System.Drawing.Point(1063, 99);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(139, 45);
            this.bAgregar.TabIndex = 56;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDetalles);
            this.groupBox1.Controls.Add(this.lblDetalles);
            this.groupBox1.Controls.Add(this.tbZona);
            this.groupBox1.Controls.Add(this.lblZona);
            this.groupBox1.Controls.Add(this.tbNumeros);
            this.groupBox1.Controls.Add(this.lblNumeros);
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.cmbDepartamentos);
            this.groupBox1.Controls.Add(this.tbCorreoCodigoCalle);
            this.groupBox1.Controls.Add(this.lblCorreoCodigoCalle);
            this.groupBox1.Controls.Add(this.lblLocalidad);
            this.groupBox1.Controls.Add(this.cmbLocalidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 245);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Contacto";
            // 
            // tbDetalles
            // 
            this.tbDetalles.Enabled = false;
            this.tbDetalles.Location = new System.Drawing.Point(622, 107);
            this.tbDetalles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDetalles.Multiline = true;
            this.tbDetalles.Name = "tbDetalles";
            this.tbDetalles.Size = new System.Drawing.Size(383, 127);
            this.tbDetalles.TabIndex = 71;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(499, 111);
            this.lblDetalles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(109, 24);
            this.lblDetalles.TabIndex = 72;
            this.lblDetalles.Text = "Detalles:";
            // 
            // tbZona
            // 
            this.tbZona.Enabled = false;
            this.tbZona.Location = new System.Drawing.Point(175, 109);
            this.tbZona.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbZona.Name = "tbZona";
            this.tbZona.Size = new System.Drawing.Size(316, 28);
            this.tbZona.TabIndex = 69;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(15, 112);
            this.lblZona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(65, 24);
            this.lblZona.TabIndex = 70;
            this.lblZona.Text = "Zona:";
            // 
            // tbNumeros
            // 
            this.tbNumeros.Enabled = false;
            this.tbNumeros.Location = new System.Drawing.Point(622, 67);
            this.tbNumeros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNumeros.Name = "tbNumeros";
            this.tbNumeros.Size = new System.Drawing.Size(383, 28);
            this.tbNumeros.TabIndex = 67;
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(499, 71);
            this.lblNumeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(87, 24);
            this.lblNumeros.TabIndex = 68;
            this.lblNumeros.Text = "Numero:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(15, 30);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(153, 24);
            this.lblDepartamento.TabIndex = 65;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(175, 27);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(313, 32);
            this.cmbDepartamentos.TabIndex = 66;
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTelefono);
            this.groupBox2.Controls.Add(this.rbDireccion);
            this.groupBox2.Controls.Add(this.rbCorreo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1043, 81);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Contacto:";
            // 
            // rbTelefono
            // 
            this.rbTelefono.AutoSize = true;
            this.rbTelefono.Location = new System.Drawing.Point(888, 36);
            this.rbTelefono.Name = "rbTelefono";
            this.rbTelefono.Size = new System.Drawing.Size(130, 28);
            this.rbTelefono.TabIndex = 2;
            this.rbTelefono.TabStop = true;
            this.rbTelefono.Text = "Teléfonos";
            this.rbTelefono.UseVisualStyleBackColor = true;
            this.rbTelefono.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // rbDireccion
            // 
            this.rbDireccion.AutoSize = true;
            this.rbDireccion.Location = new System.Drawing.Point(414, 36);
            this.rbDireccion.Name = "rbDireccion";
            this.rbDireccion.Size = new System.Drawing.Size(152, 28);
            this.rbDireccion.TabIndex = 1;
            this.rbDireccion.TabStop = true;
            this.rbDireccion.Text = "Direcciones";
            this.rbDireccion.UseVisualStyleBackColor = true;
            this.rbDireccion.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // rbCorreo
            // 
            this.rbCorreo.AutoSize = true;
            this.rbCorreo.Location = new System.Drawing.Point(6, 36);
            this.rbCorreo.Name = "rbCorreo";
            this.rbCorreo.Size = new System.Drawing.Size(108, 28);
            this.rbCorreo.TabIndex = 0;
            this.rbCorreo.TabStop = true;
            this.rbCorreo.Text = "Correos";
            this.rbCorreo.UseVisualStyleBackColor = true;
            this.rbCorreo.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // FrmContactos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.bElimiar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Contactos";
            this.Load += new System.EventHandler(this.FrmContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbLocalidades;
        private Label lblLocalidad;
        private Button bVolver;
        private TextBox tbCorreoCodigoCalle;
        private Label lblCorreoCodigoCalle;
        private Button bCancelar;
        private Button bGuardar;
        private DataGridView dgvContactos;
        private Button bElimiar;
        private Button bActualizar;
        private Button bAgregar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbTelefono;
        private RadioButton rbDireccion;
        private RadioButton rbCorreo;
        private Label lblDepartamento;
        private ComboBox cmbDepartamentos;
        private TextBox tbDetalles;
        private Label lblDetalles;
        private TextBox tbZona;
        private Label lblZona;
        private TextBox tbNumeros;
        private Label lblNumeros;
    }
}