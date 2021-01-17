using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public nUsuario geUser = new nUsuario();
        public FrmLogin()
        {
            InitializeComponent();
            panelLogin.BackColor = Color.FromArgb(240, Color.White);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="Usuario*")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario*";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(txtUsuario.Text);
                int con = int.Parse(txtContra.Text);
                eUsuario user = geUser.LoginUsuario(cod, con);
                FrmPrincipal frmPrincipal = null;
                FrmProfesorPrincipal frmProfe = null;
                FrmAlumnoPrincipal frmAlumno = null;


                if (user != null)
                {
                    if (user.Tipo == "Administrador")
                    {
                        frmPrincipal = new FrmPrincipal(user);
                        frmPrincipal.Show();
                        Hide();
                    }
                    else if (user.Tipo == "Profesor")
                    {
                        frmProfe = new FrmProfesorPrincipal(user);
                        frmProfe.Show();
                        Hide();
                    }
                    else if (user.Tipo == "Alumno")
                    {
                        frmAlumno = new FrmAlumnoPrincipal(user);
                        frmAlumno.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas, por favor ingrese otros datos", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Complete los campos, por favor", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        
        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña*";
                txtContra.UseSystemPasswordChar = false;
                txtContra.ForeColor = Color.DimGray;   
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña*")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }
    }
}