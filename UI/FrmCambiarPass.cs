using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmCambiarPass : Form
    {
        public string pass;
        private DataLayer.PasswordScore passScore;
        bool passMatch;

        public FrmCambiarPass()
        {
            InitializeComponent();
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errorCaption = "Error al cambiar la contraseña! Detalles:\n";
            //controlar campos vacios
            if (tbPasswordNuevo.Text == String.Empty || tbPasswordNuevo2.Text == String.Empty || tbPasswordAntiguo.Text == String.Empty)
            {
                error = true;
                errorCaption += "Llene todos los campos!\n";
            }

            //controlar si la contraseña antigua es correcta
            if(!error)
            {
                DataLayer.Models.LoginUser usuario = new DataLayer.Models.LoginUser()
                {
                    login_usuario = Sesion.login_usuario,
                    password_usuario = tbPasswordAntiguo.Text
                };
                bool oldPassOK = await DataLayer.Tasks.Authentication.authenticateUser(usuario);
                if (!oldPassOK)
                {
                    error = true;
                    errorCaption += "La contraseña antigua es incorrecta!\n";
                }
            }
            //controlar que las contraseñas nuevas coincidan
            if(!error && !passMatch)
            {
                error = true;
                errorCaption += "Las contraseñas no coinciden!\n";
            }

            //controlar que sea suficientemente fuerte
            if (!error)
            {
                passScore = DataLayer.Helpers.CheckStrength(tbPasswordNuevo.Text);
                if (passScore == DataLayer.PasswordScore.Blank || passScore == DataLayer.PasswordScore.TooShort || passScore == DataLayer.PasswordScore.VeryWeak)
                {
                    error = true;
                    errorCaption += "La contraseña es demasiado debil!\n";
                }
            }

            //Si todo es correcto hacer el update
            if (!error)
            {
                DataLayer.Models.Usuario usuarioActualizado = new DataLayer.Models.Usuario()
                {
                    id_nivel = Sesion.id_nivel,
                    login_usuario = Sesion.login_usuario,
                    password_usuario = tbPasswordNuevo.Text,
                    usuario_registro = Sesion.login_usuario
                };
                int statusCode = await DataLayer.Tasks.Usuario.actualizar(usuarioActualizado, Sesion.id_entidad);

                if (statusCode == 200)
                {
                    MessageBox.Show("Contraseña actualizada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sesion.password_usuario = usuarioActualizado.password_usuario;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error al sincronizar con el servidor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            //De otra manera mostrar el error en un msgbox
            else
                MessageBox.Show(errorCaption, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbPasswordNuevo_KeyUp(object sender, KeyEventArgs e)
        {
            passScore = DataLayer.Helpers.CheckStrength(tbPasswordNuevo.Text);
            switch(passScore)
            {
                case DataLayer.PasswordScore.Blank:
                    lblFuerza.Text = "=> Ninguna";
                    lblFuerza.ForeColor = Color.Black;
                    break;
                case DataLayer.PasswordScore.TooShort:
                    lblFuerza.Text = "===> Muy Corta";
                    lblFuerza.ForeColor = Color.DarkRed;
                    break;
                case DataLayer.PasswordScore.VeryWeak:
                    lblFuerza.Text = "=====> Demasiado Débil";
                    lblFuerza.ForeColor = Color.Red;
                    break;
                case DataLayer.PasswordScore.Weak:
                    lblFuerza.Text = "=======> Débil";
                    lblFuerza.ForeColor = Color.Orange;
                    break;
                case DataLayer.PasswordScore.Medium:
                    lblFuerza.Text = "=====> Moderada";
                    lblFuerza.ForeColor = Color.Yellow;
                    break;
                case DataLayer.PasswordScore.Strong:
                    lblFuerza.Text = "======> Fuerte";
                    lblFuerza.ForeColor = Color.YellowGreen;
                    break;
                case DataLayer.PasswordScore.VeryStrong:
                    lblFuerza.Text = "========> Muy Fuerte";
                    lblFuerza.ForeColor = Color.Green;
                    break;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPasswordNuevo.Text == tbPasswordNuevo2.Text)
            {
                this.passMatch = true;
                lblCoincidencia.Visible = false;
            }
            else
            {
                this.passMatch = false;
                lblCoincidencia.Visible = true;
            }
        }
    }
}
