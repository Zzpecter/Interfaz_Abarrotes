namespace UI
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bRegistroCompras = new System.Windows.Forms.Button();
            this.bReportes = new System.Windows.Forms.Button();
            this.bRegistroVentas = new System.Windows.Forms.Button();
            this.bListadoCompras = new System.Windows.Forms.Button();
            this.bListadoVentas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bProveedores = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bUsuarios = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bDisposiciones = new System.Windows.Forms.Button();
            this.bUnidades = new System.Windows.Forms.Button();
            this.bPresentaciones = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bLocalidades = new System.Windows.Forms.Button();
            this.bAlmacenes = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.bDescuentos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bDescuentos);
            this.groupBox1.Controls.Add(this.bRegistroCompras);
            this.groupBox1.Controls.Add(this.bReportes);
            this.groupBox1.Controls.Add(this.bRegistroVentas);
            this.groupBox1.Controls.Add(this.bListadoCompras);
            this.groupBox1.Controls.Add(this.bListadoVentas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión Financiera";
            // 
            // bRegistroCompras
            // 
            this.bRegistroCompras.Image = global::UI.Properties.Resources.buy;
            this.bRegistroCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRegistroCompras.Location = new System.Drawing.Point(202, 85);
            this.bRegistroCompras.Name = "bRegistroCompras";
            this.bRegistroCompras.Size = new System.Drawing.Size(167, 103);
            this.bRegistroCompras.TabIndex = 2;
            this.bRegistroCompras.Text = "Registro Compras";
            this.bRegistroCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRegistroCompras.UseVisualStyleBackColor = true;
            this.bRegistroCompras.Click += new System.EventHandler(this.bRegistroCompras_Click);
            // 
            // bReportes
            // 
            this.bReportes.Location = new System.Drawing.Point(391, 209);
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(245, 57);
            this.bReportes.TabIndex = 5;
            this.bReportes.Text = "Reportes";
            this.bReportes.UseVisualStyleBackColor = true;
            this.bReportes.Click += new System.EventHandler(this.bReportes_Click);
            // 
            // bRegistroVentas
            // 
            this.bRegistroVentas.Image = global::UI.Properties.Resources.sell;
            this.bRegistroVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRegistroVentas.Location = new System.Drawing.Point(6, 85);
            this.bRegistroVentas.Name = "bRegistroVentas";
            this.bRegistroVentas.Size = new System.Drawing.Size(190, 103);
            this.bRegistroVentas.TabIndex = 1;
            this.bRegistroVentas.Text = "Registro Ventas";
            this.bRegistroVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRegistroVentas.UseVisualStyleBackColor = true;
            this.bRegistroVentas.Click += new System.EventHandler(this.bRegistroVentas_Click);
            // 
            // bListadoCompras
            // 
            this.bListadoCompras.Location = new System.Drawing.Point(391, 85);
            this.bListadoCompras.Name = "bListadoCompras";
            this.bListadoCompras.Size = new System.Drawing.Size(245, 57);
            this.bListadoCompras.TabIndex = 4;
            this.bListadoCompras.Text = "Listado de Compras";
            this.bListadoCompras.UseVisualStyleBackColor = true;
            this.bListadoCompras.Click += new System.EventHandler(this.bListadoCompras_Click);
            // 
            // bListadoVentas
            // 
            this.bListadoVentas.Location = new System.Drawing.Point(391, 22);
            this.bListadoVentas.Name = "bListadoVentas";
            this.bListadoVentas.Size = new System.Drawing.Size(245, 57);
            this.bListadoVentas.TabIndex = 3;
            this.bListadoVentas.Text = "Listado de Ventas";
            this.bListadoVentas.UseVisualStyleBackColor = true;
            this.bListadoVentas.Click += new System.EventHandler(this.bListadoVentas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bProveedores);
            this.groupBox2.Controls.Add(this.bClientes);
            this.groupBox2.Controls.Add(this.bUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestión RR HH";
            // 
            // bProveedores
            // 
            this.bProveedores.Location = new System.Drawing.Point(17, 178);
            this.bProveedores.Name = "bProveedores";
            this.bProveedores.Size = new System.Drawing.Size(288, 57);
            this.bProveedores.TabIndex = 5;
            this.bProveedores.Text = "Gestión de Proveedores";
            this.bProveedores.UseVisualStyleBackColor = true;
            this.bProveedores.Click += new System.EventHandler(this.bProveedores_Click);
            // 
            // bClientes
            // 
            this.bClientes.Location = new System.Drawing.Point(17, 115);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(288, 57);
            this.bClientes.TabIndex = 4;
            this.bClientes.Text = "Gestión de Clientes";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bUsuarios
            // 
            this.bUsuarios.Location = new System.Drawing.Point(17, 52);
            this.bUsuarios.Name = "bUsuarios";
            this.bUsuarios.Size = new System.Drawing.Size(288, 57);
            this.bUsuarios.TabIndex = 3;
            this.bUsuarios.Text = "Gestión de Usuarios";
            this.bUsuarios.UseVisualStyleBackColor = true;
            this.bUsuarios.Click += new System.EventHandler(this.bUsuarios_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bDisposiciones);
            this.groupBox3.Controls.Add(this.bUnidades);
            this.groupBox3.Controls.Add(this.bPresentaciones);
            this.groupBox3.Controls.Add(this.bProductos);
            this.groupBox3.Location = new System.Drawing.Point(341, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 289);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestión de Productos";
            // 
            // bDisposiciones
            // 
            this.bDisposiciones.Location = new System.Drawing.Point(18, 219);
            this.bDisposiciones.Name = "bDisposiciones";
            this.bDisposiciones.Size = new System.Drawing.Size(337, 57);
            this.bDisposiciones.TabIndex = 6;
            this.bDisposiciones.Text = "Disposiciones";
            this.bDisposiciones.UseVisualStyleBackColor = true;
            this.bDisposiciones.Click += new System.EventHandler(this.bDisposiciones_Click);
            // 
            // bUnidades
            // 
            this.bUnidades.Location = new System.Drawing.Point(18, 156);
            this.bUnidades.Name = "bUnidades";
            this.bUnidades.Size = new System.Drawing.Size(337, 57);
            this.bUnidades.TabIndex = 5;
            this.bUnidades.Text = "Gestionar Unidades";
            this.bUnidades.UseVisualStyleBackColor = true;
            this.bUnidades.Click += new System.EventHandler(this.bUnidades_Click);
            // 
            // bPresentaciones
            // 
            this.bPresentaciones.Location = new System.Drawing.Point(18, 93);
            this.bPresentaciones.Name = "bPresentaciones";
            this.bPresentaciones.Size = new System.Drawing.Size(337, 57);
            this.bPresentaciones.TabIndex = 4;
            this.bPresentaciones.Text = "Gestionar Presentaciones";
            this.bPresentaciones.UseVisualStyleBackColor = true;
            this.bPresentaciones.Click += new System.EventHandler(this.bPresentaciones_Click);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(18, 30);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(337, 57);
            this.bProductos.TabIndex = 3;
            this.bProductos.Text = "Gestionar Productos";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bLocalidades);
            this.groupBox4.Controls.Add(this.bAlmacenes);
            this.groupBox4.Location = new System.Drawing.Point(729, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 197);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gestión - Otros";
            // 
            // bLocalidades
            // 
            this.bLocalidades.Location = new System.Drawing.Point(17, 115);
            this.bLocalidades.Name = "bLocalidades";
            this.bLocalidades.Size = new System.Drawing.Size(337, 57);
            this.bLocalidades.TabIndex = 4;
            this.bLocalidades.Text = "Gestionar Localidades";
            this.bLocalidades.UseVisualStyleBackColor = true;
            this.bLocalidades.Click += new System.EventHandler(this.bLocalidades_Click);
            // 
            // bAlmacenes
            // 
            this.bAlmacenes.Location = new System.Drawing.Point(17, 52);
            this.bAlmacenes.Name = "bAlmacenes";
            this.bAlmacenes.Size = new System.Drawing.Size(337, 57);
            this.bAlmacenes.TabIndex = 3;
            this.bAlmacenes.Text = "Gestionar Almacenes";
            this.bAlmacenes.UseVisualStyleBackColor = true;
            this.bAlmacenes.Click += new System.EventHandler(this.bAlmacenes_Click);
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bSalir.Image = global::UI.Properties.Resources.exit;
            this.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSalir.Location = new System.Drawing.Point(897, 504);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(192, 69);
            this.bSalir.TabIndex = 60;
            this.bSalir.Text = "Salir";
            this.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Location = new System.Drawing.Point(746, 143);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(337, 57);
            this.bPerfil.TabIndex = 4;
            this.bPerfil.Text = "Mi Perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Cascadia Code SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUsuarioActual.Location = new System.Drawing.Point(798, 38);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(215, 40);
            this.lblUsuarioActual.TabIndex = 61;
            this.lblUsuarioActual.Text = "Bienvenid@:";
            this.lblUsuarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bDescuentos
            // 
            this.bDescuentos.Location = new System.Drawing.Point(391, 146);
            this.bDescuentos.Name = "bDescuentos";
            this.bDescuentos.Size = new System.Drawing.Size(245, 57);
            this.bDescuentos.TabIndex = 6;
            this.bDescuentos.Text = "Descuentos";
            this.bDescuentos.UseVisualStyleBackColor = true;
            this.bDescuentos.Click += new System.EventHandler(this.bDescuentos_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 602);
            this.Controls.Add(this.lblUsuarioActual);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button bRegistroCompras;
        private Button bReportes;
        private Button bRegistroVentas;
        private Button bListadoCompras;
        private Button bListadoVentas;
        private GroupBox groupBox2;
        private Button bProveedores;
        private Button bClientes;
        private Button bUsuarios;
        private GroupBox groupBox3;
        private Button bUnidades;
        private Button bPresentaciones;
        private Button bProductos;
        private GroupBox groupBox4;
        private Button bAlmacenes;
        private Button bLocalidades;
        private Button bSalir;
        private Button bPerfil;
        private Label lblUsuarioActual;
        private Button bDisposiciones;
        private Button bDescuentos;
    }
}