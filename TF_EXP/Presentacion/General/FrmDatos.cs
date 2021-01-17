using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FrmDatos : Form
    {
        eUsuario user = new eUsuario();
        nUsuario geUsu = new nUsuario();

        public FrmDatos(eUsuario u)
        {
            InitializeComponent();
            user = geUsu.DatosUsuario(u.Codigo);
            lblDatos.Text = "Datos del " + user.Tipo;
            lblDNI.Text = user.DNI.ToString();
            lblCodigo.Text = user.Codigo.ToString();
            lblNombre.Text = user.Nombre;
            lblApellido.Text = user.Apellido;
            lblCorreo.Text = user.Correo;
            lblContra.Text = user.Contra.ToString();
            //deshabilitarCampos();
        }

        public FrmDatos()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //if (user.Nombre != txtNombre.Text || user.Correo!=txtCorreo.Text)
            //{
            //    geUsu.ModificarUsuario(user);
            //    MessageBox.Show("Datos de " + user.Tipo + " modificado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Limpiar();
            //}
            //else
            //{
            //    MessageBox.Show("No se han realizado cambios", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //}            
        }


        //private void Limpiar()
        //{
        //    txtCodigo.Clear();
        //    txtDNI.Clear();
        //    txtNombre.Clear();
        //    txtApellido.Clear();
        //    txtCorreo.Clear();
        //    txtContra.Clear();
        //    comboTipo.SelectedIndex = -1;
        //}
    }
}
