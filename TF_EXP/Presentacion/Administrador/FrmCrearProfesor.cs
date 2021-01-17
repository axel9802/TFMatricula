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
    public partial class FrmCrearProfesor : Form
    {
        nUsuario geUsu = new nUsuario();
        eUsuario user = null;
        
        public FrmCrearProfesor()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtContra.Clear();
        }

        private bool DNIExiste(int dni)
        {
            return geUsu.listarUsuarios().Exists(delegate (eUsuario value)
            {
                return value.DNI == dni;
            });
        }

        private bool CodigoExiste(int cod)
        {
            return geUsu.listarUsuarios().Exists(delegate (eUsuario value)
            {
                return value.Codigo == cod;
            });
        }

        private bool CorreoExiste(string cor)
        {
            return geUsu.listarUsuarios().Exists(delegate (eUsuario value)
            {
                return value.Correo == cor;
            });
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(txtCodigo.Text);
                int dni = int.Parse(txtDNI.Text);
                string nom = txtNombre.Text;
                string ape = txtApellido.Text;
                string cor = txtCorreo.Text;
                int con = int.Parse(txtContra.Text);

                if (nom != "" && ape != "" && cor != "")
                {
                    if (!DNIExiste(dni) && !CodigoExiste(cod))
                    {
                        if (dni > 10000000 && dni < 99999999)
                        {
                            if (cod > 10000 && cod < 99999)
                            {
                                if (con > 10000 && con < 99999)
                                {
                                    user = new eUsuario();
                                    user.Codigo = cod;
                                    user.DNI = dni;
                                    user.Nombre = nom;
                                    user.Apellido = ape;
                                    user.Correo = cor;
                                    user.Contra = con;
                                    geUsu.RegistrarProfesor(user);
                                    MessageBox.Show("Profesor registrado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    listarUsuarios();
                                    Limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña inválida, intente ingresando otra", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Código inválido, intente ingresando otro", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DNI inválido, intente ingresando otro", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El profesor ya existe, por favor ingrese otros datos", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Complete los datos", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Complete los datos", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void FrmCreaUsuario_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void listarUsuarios()
        {
            dgUusarios.DataSource = geUsu.listarProfes();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(sender, e);
        }

        private void Habilitar()
        {
            txtCodigo.Enabled = true;
            txtDNI.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(txtCodigo.Text);
                string nom = txtNombre.Text;
                string ape = txtApellido.Text;
                string cor = txtCorreo.Text;
                int con = int.Parse(txtContra.Text);

                if (nom != "" && ape != "" && cor != "")
                {
                    user = new eUsuario();
                    user.Codigo = cod;
                    user.Nombre = nom;
                    user.Apellido = ape;
                    user.Correo = cor;
                    user.Contra = con;

                    geUsu.ModificarUsuario(user);
                    MessageBox.Show("Datos del profesor modificados correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarUsuarios();
                    Limpiar();
                    Habilitar();
                }
                else
                {
                    MessageBox.Show("Complete los datos", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Seleccione un usuario", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(txtDNI.Text);

                geUsu.EliminarUsuario(dni);
                MessageBox.Show("Profesor eliminado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarUsuarios();
                Limpiar();
                Habilitar();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un usuario", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void dgUusarios_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = dgUusarios.CurrentRow.Cells[0].Value.ToString();
            txtDNI.Text = dgUusarios.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgUusarios.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgUusarios.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgUusarios.CurrentRow.Cells[5].Value.ToString();
            txtContra.Text = dgUusarios.CurrentRow.Cells[6].Value.ToString();
            txtCodigo.Enabled = false;
            txtDNI.Enabled = false;
        }
    }
}