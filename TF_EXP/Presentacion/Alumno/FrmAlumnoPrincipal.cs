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
    public partial class FrmAlumnoPrincipal : Form
    {
        public eUsuario user = new eUsuario();

        public FrmAlumnoPrincipal(eUsuario u)
        {
            user = u;
            InitializeComponent();
            panelPrincipal.BackColor = Color.FromArgb(190, Color.White);
        }

        public FrmAlumnoPrincipal()
        {
            InitializeComponent();
        }

        private void cargarLabel()
        {
            lblNOMBRE.Text = user.Nombre;
            lblCORREO.Text = user.Codigo.ToString();
            lblTIPO.Text = user.Tipo;
            lbltitulo.Text = "Admisión UPC";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);        

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 215)
            {
                MenuVertical.Width = 50;
            }
            else MenuVertical.Width = 215;
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Hide();
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
        }

        private Form formActivo = null;
        private void abrirFormulario(Form formPanel)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formPanel;
            formPanel.TopLevel = false;
            formPanel.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(formPanel);
            PanelContenedor.Tag = formPanel;
            formPanel.BringToFront();
            formPanel.Show();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmDatos(user));
            lbltitulo.Text = "Datos";
        }

        private void FrmAlumnoPrincipal_Load_1(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInicio());
            lbltitulo.Text = "Noticias UPC";
            cargarLabel();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ConsultaCursoAlumno(user));
            lbltitulo.Text = "Consulta de Cursos";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInicio());
            lbltitulo.Text = "Noticias UPC";
        }
    }
}